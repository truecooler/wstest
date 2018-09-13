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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        /*TODO: Задание для Вадима: сделай проверку на наличие пользователя в бд
         * прежде, чем занести его в бд. в противном случае, в бд заноситься 2 одинаковых
         * пользователя */
        private void button1_Click(object sender, EventArgs e)
        {
            //обработчик кнопки регистрации
            try
            {
                string login = textBox1.Text;
                int age = Convert.ToInt32(textBox3.Text);
                string password = textBox2.Text;
                Globals.MysqlQuery.CommandText = $"INSERT INTO users (name,age,password) VALUES ('{login}','{age}','{password}');";

                /* этот вариант реализует защиту от sql инъекций, но он портит читаемость
                 * нам пока рано решать вопросы безопасности, так что не будем использовать этот способ
                 */
                //mainForm.command.Parameters.AddWithValue("name", login);
                //mainForm.command.Parameters.AddWithValue("age", age);
                //mainForm.command.Parameters.AddWithValue("password", password);


                /*
                 * выполняем запрос на изменение данных в бд
                 * rowsAffected будет хранить количество затронутых строк
                 * если мы затронули хотя бы одну строку, то данные успешно занесены в бд
                 * 
                 */
                int rowsAffected = Globals.MysqlQuery.ExecuteNonQuery();
                //mainForm.command.Parameters.Clear();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Ошибка, зарегистрироваться не удалось");
                }
                else
                {
                    MessageBox.Show("Вы успешно зарегистрировались! Вы можете авторизоваться с новыми данными.");
                    
                    this.Close();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
                Globals.MysqlConnection.Close();
            }

            /*
             * этот обработчик нужен на случай, если пользователь
             * введет какую-нибудь дрянь вместо возраста, например строку
             * программа кинет исключение, этот обработчик его словит
             */
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }

        }
    }
}
