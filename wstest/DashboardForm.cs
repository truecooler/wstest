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
        private AuthForm mainForm = null;
        public DashboardForm(Form callingForm)
        {
            mainForm =(AuthForm) callingForm;
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(((Form1)mainForm).conn.ConnectionString);
            //mainForm.conn.Close();
            this.Hide();
            mainForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
