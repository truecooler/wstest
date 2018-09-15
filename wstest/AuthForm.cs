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
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBox1.Text; //кладем логин из текст бокса в переменную
                string password = textBox2.Text; //аналогично выше, только для пароля

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
                Globals.MysqlConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm form = new RegForm();
            form.ShowDialog();
            this.Show();
            
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * подключение к бд. 
                 * создаем экземпляр MySqlConnection, через который мы будем взаимодействовать в бд
                 * передаем туда наши настройки в виде строки
                 */
                Globals.MysqlConnection = new MySqlConnection(Globals.MysqlConnectionSettingsString);
                /* открываем соединение */
                this.button3.Text = "Соединяемся с бд...";
                /* выполняем подключение асинхронно, что бы не блокировать
                 * окно приложения 
                 */
                await Globals.MysqlConnection.OpenAsync();
                this.button3.Text = "Соединение с бд установлено!";
                //создаем экземпляр MySqlCommand. он тоже нужен для нашей работы. 
                //первый параметр: запрос к бд(в данном случае примитивный, который ничего не делает)
                //второй: экземпляр соединения с бд
                Globals.MysqlQuery = new MySqlCommand("select 1", Globals.MysqlConnection);

                /* делаем кнопки авторизации и регистрации доступными для нажатия */
                button1.Enabled = true;
                button2.Enabled = true;
                //MessageBox.Show("Успех");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
                Globals.MysqlConnection.Close();
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
    }
}
