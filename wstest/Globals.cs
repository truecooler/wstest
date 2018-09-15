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
		static public MySqlConnectionStringBuilder MysqlConnectionSettings = null;
		//static public string MysqlConnectionSettingsString = "server=vpn.thecooler.ru;user=cooler;database=ws;password=j8y3f4h5;";
		static public MySqlConnection MysqlConnection = null;
        static public MySqlCommand MysqlQuery = null;
        static public MySqlDataReader MysqlDataReader = null;
    }
}
