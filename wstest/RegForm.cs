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

        /*TODO: Новое задание для Вадима: сделай проверку всех полей на пустоту при регистрации
		 * если ничего не заполнить, в бд просто добавиться пустая запись, а это не хорошо */
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //обработчик кнопки регистрации
            try
            {

                if (textBoxLogin.Text == "" || textBoxPass.Text == "" || textBoxAge.Text == "") 
                {
                    throw new Exception("Заполните все поля");
                    //return;
                }


                if (textBoxLogin.Text.Contains(" ") || textBoxPass.Text.Contains(" ") || textBoxAge.Text.Contains(" "))
                {
                    throw new Exception("Пробелы использовать нельзя");
                    //return;
                }

                string login = textBoxLogin.Text;
                int age = Convert.ToInt32(textBoxAge.Text);
                string password = textBoxPass.Text;
                Globals.MysqlQuery.CommandText = $"select * from users where name = '{login}';";
				Globals.MysqlDataReader = Globals.MysqlQuery.ExecuteReader();
                if (Globals.MysqlDataReader.HasRows)
                {
					Globals.MysqlDataReader.Close();
					MessageBox.Show("Данный логин уже занят, напишите другой");
					return;
                }
				Globals.MysqlDataReader.Close();

				//Globals.MysqlQuery.CommandText = "INSERT INTO `ws`.`users` (`name`, `age`, `password`, `position`) VALUES ('ку2', '123', '111', 'Клиент');";

				Globals.MysqlQuery.CommandText = $"INSERT INTO users (name,age,password,position) VALUES ('{login}','{age}','{password}','Клиент');";

				//MessageBox.Show(Globals.MysqlQuery.CommandText);
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
