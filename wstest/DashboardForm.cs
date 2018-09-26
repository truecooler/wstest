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
    public partial class DashboardForm : Form
    {
        int user_id = 0;
        public DashboardForm(string login,int user_id, string position)
        {
            InitializeComponent();
            this.label3.Text = login;
            this.user_id = user_id;
            this.Text = "Панель управления " + position + "а";
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
			Globals.MysqlLog(this.user_id, "Выход");
            Globals.MySQLsetOnline(this.user_id, 0);
            this.Close();   
        }



        private void DashboardForm_Load(object sender, EventArgs e)
        {
			
		}

		private void DashboardForm_Click(object sender, EventArgs e)
		{
		}

		//     private void button2_Click(object sender, EventArgs e)
		//     {
		//         MySqlCommand MysqlQuery = new MySqlCommand("SELECT * FROM users",Globals.MysqlConnection);

		//using (MySqlDataReader MysqlDataReader = MysqlQuery.ExecuteReader())
		//{
		//	DataTable tb = new DataTable();
		//	tb.Load(MysqlDataReader);
		//	this.dataGridView1.DataSource = tb;
		//}
		//     }
	}
}
