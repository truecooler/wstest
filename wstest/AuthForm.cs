using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wstest
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {

            InitializeComponent();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBoxLogin.Text; //кладем логин из текст бокса в переменную
                string password = textBoxPass.Text; //аналогично выше, только для пароля

                /* задаем запрос для базы данных */
            Globals.MysqlQuery.CommandText = $"SELECT* FROM users WHERE name = '{login}' AND password = '{password}'";
                /* выполняем запрос */
                Globals.MysqlDataReader = Globals.MysqlQuery.ExecuteReader();

                /* проверяем, вернула ли база данных хоть одну строку */
                if (Globals.MysqlDataReader.HasRows)
                {
                    Globals.MysqlDataReader.Close();
                    //MessageBox.Show("Авторизация успешна");

                    /* создаем экемпляр формы*/
                    DashboardForm form = new DashboardForm(login);

                    /* прячем окно авторизации */
                    this.Hide();

                    /* показываем новую форму. как только новое окно закроется, управление 
                     * передастся на this.Show(); */
                    form.ShowDialog();
                    this.Show();

                    /* закрываем эту, она нам пока больше не нужна */
                   
                }
                else
                {
                    
                    MessageBox.Show("Неверный логин или пароль");
                    Globals.MysqlDataReader.Close();
                }
                

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void buttonOpenRegisterForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm form = new RegForm();
            form.ShowDialog();
            this.Show();
            
        }

        private async void buttonMysqlConnect_Click(object sender, EventArgs e)
        {
            try
            {

				/*
				 * проверка на необходимость сохранения пароля в хранилище
				 * что бы не вводить пароль от mysql каждый раз
				 * когда форма запускается, срабатывает обработчик Form.OnLoad,
				 * который считывает пароль из хранилища и вводит его в поле автоматически
				 */

				if (checkBoxNeedToRemember.Checked)
				{
					//кладем значение из поля в хранилище по ключу
					Properties.Settings.Default["cooler_super_secret"] = textBoxMysqlPass.Text;
					//сохраняем хранилище
					Properties.Settings.Default.Save();
				}


				/*
                 * подключение к бд. 
                 * создаем экземпляр MySqlConnection, через который мы будем взаимодействовать в бд
                 * передаем туда наши настройки в виде экземпляра MySqlConnectionStringBuilder.
				 * его же мы настраиваем, выдавая значение каждому параметру отдельно.
				 * это более наглядно и удобно, посравнению со старым способом в виде обычной строки
                 */

				Globals.MysqlConnectionSettings = new MySqlConnectionStringBuilder();
				Globals.MysqlConnectionSettings.Server = HomeMode ? "192.168.10.7" : "vpn.thecooler.ru"; //это нужно для меня, потом объясню почему и что это
				Globals.MysqlConnectionSettings.UserID = "cooler";
				Globals.MysqlConnectionSettings.Database = "ws";
				Globals.MysqlConnectionSettings.Password = textBoxMysqlPass.Text;
				Globals.MysqlConnectionSettings.CharacterSet = "utf8";


				Globals.MysqlConnection = new MySqlConnection(Globals.MysqlConnectionSettings.ToString());
                /* открываем соединение */
                this.buttonMysqlConnect.Text = "Соединяемся с бд...";
                /* выполняем подключение асинхронно, что бы не блокировать
                 * окно приложения 
                 */
                await Globals.MysqlConnection.OpenAsync();
                this.buttonMysqlConnect.Text = "Соединение с бд установлено!";
                //создаем экземпляр MySqlCommand. он тоже нужен для нашей работы. 
                //первый параметр: запрос к бд(в данном случае примитивный, который ничего не делает)
                //второй: экземпляр соединения с бд
                Globals.MysqlQuery = new MySqlCommand("select 1", Globals.MysqlConnection);

                /* делаем кнопки авторизации и регистрации доступными для нажатия */
                buttonLogin.Enabled = true;
                buttonOpenRegisterForm.Enabled = true;
                //MessageBox.Show("Успех");

            }
            catch (MySqlException ex) //ловим исключение от mysql
            {
				this.buttonMysqlConnect.Text = "Подключиться не удалось, попробуйте снова";

				MessageBox.Show("Ошибка: " + ex.ToString());
            }
			catch (Exception ex) //ловим все остальные исключения
			{
				this.buttonMysqlConnect.Text = "Подключиться не удалось, попробуйте снова";
				MessageBox.Show("Ошибка: " + ex.ToString());
			}
            finally
            {
                //в этом блоке описывается код, который выполнится в любом случае, после отлова исключения, или успешного выполнения
                //нам пока не нужно выполнять тут код
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void AuthForm_Load(object sender, EventArgs e)
		{
			//подгружаем пароль из хранилища в текстовое поле
			textBoxMysqlPass.Text = Properties.Settings.Default["cooler_super_secret"].ToString();
		}

		static bool HomeMode = false;
		private void AuthForm_DoubleClick(object sender, EventArgs e)
		{
			if (HomeMode == false)
			{
				this.Text += " / server at: 192.168.10.7";
				HomeMode = true;
			}
			else
			{
				this.Text =  this.Text.Replace(" / server at: 192.168.10.7", "");
				HomeMode = false;
			}

		}

	}
}
