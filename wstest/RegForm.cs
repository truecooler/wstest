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
        private AuthForm mainForm = null;
        public RegForm(Form callingForm)
        {
            mainForm = (AuthForm)callingForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBox1.Text;
                int age = Convert.ToInt32(textBox3.Text);
                string password = textBox2.Text;
                mainForm.command.CommandText = "INSERT INTO users (name,age,password) VALUES (?name,?age,?password);";
                mainForm.command.Parameters.AddWithValue("name", login);
                mainForm.command.Parameters.AddWithValue("age", age);
                mainForm.command.Parameters.AddWithValue("password", password);
                int rowsAffected = mainForm.command.ExecuteNonQuery();
                mainForm.command.Parameters.Clear();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Ошибка, зарегистрироваться не удалось");
                }
                else
                {
                    MessageBox.Show("Вы успешно зарегистрировались! Вы можете авторизоваться с новыми данными.");
                    this.Hide();
                    mainForm.Show();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
                mainForm.conn.Close();
            }
            finally
            {
                //
            }
        }
    }
}
