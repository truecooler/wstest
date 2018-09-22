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


        private void buttonRegister_Click(object sender, EventArgs e)
        {
			try
			{
				if (textBoxLogin.Text == "" || textBoxPass.Text == "" || textBoxAge.Text == "")
				{
					MessageBox.Show("Заполните все поля");
					return;
				}

				if (textBoxLogin.Text.Contains(" ") || textBoxPass.Text.Contains(" ") || textBoxAge.Text.Contains(" "))
				{
					MessageBox.Show("Пробелы использовать нельзя");
					return;
				}

				string login = textBoxLogin.Text;
				int age = Convert.ToInt32(textBoxAge.Text);
				string password = textBoxPass.Text;
				MySqlCommand MysqlQuery = new MySqlCommand($"select * from users where name = '{login}'", Globals.MysqlConnection);
				using (MySqlDataReader MysqlDataReader = MysqlQuery.ExecuteReader())
				{
					if (MysqlDataReader.HasRows)
					{
						MessageBox.Show("Данный логин уже занят, напишите другой");
						return;
					}
				}

				MysqlQuery.CommandText = $"INSERT INTO users (name,age,password,position) VALUES ('{login}','{age}','{password}','Клиент');";

				int rowsAffected = MysqlQuery.ExecuteNonQuery();

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
