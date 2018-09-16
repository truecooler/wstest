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
		static public MySqlConnection MysqlConnection = null;
        static public MySqlCommand MysqlQuery = null;
        static public MySqlDataReader MysqlDataReader = null;
    }
}
