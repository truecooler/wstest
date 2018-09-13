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
        string connStr = "server=vpn.thecooler.ru;user=cooler;database=ws;password=pass;";
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataReader reader;

        DashboardForm form2=null;
        RegForm form3=null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textBox1.Text;
                string password = textBox2.Text;
                string sql = "SELECT * FROM users WHERE name=?login AND password = ?password";
                command.CommandText = sql;
                command.Parameters.AddWithValue("?login", login);
                command.Parameters.AddWithValue("?password", password);
                
                reader = command.ExecuteReader();
                command.Parameters.Clear();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Авторизация успешна");

                    
                    command.CommandText = "SELECT * FROM users;";
                    reader = command.ExecuteReader();

                    DataTable tb = new DataTable();
                    tb.Load(reader);

                    form2 = new DashboardForm(this);
                    form2.dataGridView1.DataSource = tb;
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    
                    MessageBox.Show("Неверный логин или пароль");
                    //conn.Close();
                }
                reader.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
                conn.Close();
            }
            finally
            {
                //
            }
            //while (reader.Read())
            //MessageBox.Show (reader[0].ToString() + reader[1] + reader[2] + reader[3]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form3 == null)
            {
                form3 = new RegForm(this);
            }
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                command = new MySqlCommand("select 1", conn);
                button1.Enabled = true;
                button2.Enabled = true;
                MessageBox.Show("Успех");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
                conn.Close();
            }
            finally
            {
                //
            }
        }
    }
}
