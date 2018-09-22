using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace wstest
{
    static class Globals
    {
		static public MySqlConnection MysqlConnection = null;

		static public void MysqlLog(int userid,string type)
		{
			MySqlCommand MysqlQuery = new MySqlCommand($"insert into logs (time,user_id,event) values (NOW(),'{userid}','{type}');", MysqlConnection);

			int rowsAffected = MysqlQuery.ExecuteNonQuery();

			if (rowsAffected == 0)
			{
				MessageBox.Show("Ошибка логирования пизда");
				return;
			}
		}
    }
}
