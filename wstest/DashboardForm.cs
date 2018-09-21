using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wstest
{
    public partial class DashboardForm : Form
    {
        int user_id = 0;
        public DashboardForm(string login,int user_id)
        {
            InitializeComponent();
            this.label3.Text = login;
            this.user_id = user_id;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
                Globals.MysqlQuery.CommandText = $"insert into logs (time,user_id,event) values (NOW(),'{this.user_id}','Выход');";
                int rowsAffected = Globals.MysqlQuery.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Ошибка выхода, попробуйте еще раз");
                }
                else
                {    //обработчик кнопки выхода с аккаунта
                    //просто создаем новую форму авторизации, и закрываем текущее окно
                    this.Close();
                }
        }



        private void DashboardForm_Load(object sender, EventArgs e)
        {
            //обработчик загрузки формы
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.MysqlQuery.CommandText = "SELECT * FROM users;";
            Globals.MysqlDataReader = Globals.MysqlQuery.ExecuteReader();

            /* создаем класс, в котором мы будем хранить принятую таблицу от базы 
             * (база данных всегда возвращает запрос ввиде новой таблицы) */
            DataTable tb = new DataTable();
            /* загружаем данные из sql ридера в наш класс */
            tb.Load(Globals.MysqlDataReader);
            /* задаем элементу dataGridView на форме данные, который хранит в себе новоиспеченный DataTable */
            this.dataGridView1.DataSource = tb;
            //каждый раз, работая с ридером, его нужно закрывать
            Globals.MysqlDataReader.Close();
        }
    }
}
