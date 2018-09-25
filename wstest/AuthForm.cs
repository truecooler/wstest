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
				if (checkBox1.Checked)
				{
					Properties.Settings.Default["login"] = textBoxLogin.Text;
					Properties.Settings.Default["password"] = textBoxPass.Text;
					Properties.Settings.Default.Save();
				}
				string login = textBoxLogin.Text; 
				string password = textBoxPass.Text; 

				/* задаем запрос для базы данных */
				MySqlCommand MysqlQuery = new MySqlCommand($"SELECT* FROM users WHERE name = '{login}' AND password = '{password}'", Globals.MysqlConnection);
                string position = "";
                
                
				
				DataTable tb = new DataTable();
				/* выполняем запрос */
				using (MySqlDataReader MysqlDataReader = MysqlQuery.ExecuteReader())
				{
					tb.Load(MysqlDataReader);
				}//эта конструкция автоматически закрывает ридер

				if (tb.Rows.Count == 0)
				{
					MessageBox.Show("Неверный логин или пароль");
					return;
				}
				int userid = (int)tb.Rows[0][0];
                position = (string)tb.Rows[0][4];
				Globals.MysqlLog(userid, "Вход");
                Globals.MySQLsetOnline(userid, 1);
                DashboardForm form = new DashboardForm(login, userid, position);
          

				this.Hide();
				/* показываем новую форму. как только новое окно закроется, управление 
                       * передастся на this.Show(); */
				form.ShowDialog();
				this.Show();
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
				if (checkBoxNeedToRemember.Checked)
				{
					//кладем значение из поля в хранилище по ключу
					Properties.Settings.Default["sqlpass"] = textBoxMysqlPass.Text;
					//сохраняем хранилище
					Properties.Settings.Default.Save();
				}

				MySqlConnectionStringBuilder MysqlConnectionSettings = new MySqlConnectionStringBuilder();
				MysqlConnectionSettings.Server = HomeMode ? "192.168.10.7" : "vpn.thecooler.ru"; //это нужно для меня, потом объясню почему и что это
				MysqlConnectionSettings.UserID = "cooler";
				MysqlConnectionSettings.Database = "ws";
				MysqlConnectionSettings.Password = textBoxMysqlPass.Text;
				MysqlConnectionSettings.CharacterSet = "utf8";

				Globals.MysqlConnection = new MySqlConnection(MysqlConnectionSettings.ToString());
                /* открываем соединение */
                this.buttonMysqlConnect.Text = "Соединяемся с бд...";
                /* выполняем подключение асинхронно, что бы не блокировать
                 * окно приложения 
                 */
                await Globals.MysqlConnection.OpenAsync();
                this.buttonMysqlConnect.Text = "Соединение с бд установлено!";
                
                buttonLogin.Enabled = true;
                buttonOpenRegisterForm.Enabled = true;
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

        }

		private void AuthForm_Load(object sender, EventArgs e)
		{
			//подгружаем пароль из хранилища в текстовое поле
			textBoxMysqlPass.Text = Properties.Settings.Default["sqlpass"].ToString();
            textBoxLogin.Text = Properties.Settings.Default["login"].ToString();
            textBoxPass.Text = Properties.Settings.Default["password"].ToString();
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
