using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace net_gui_mysql_demo
{
    class DBMgr
    {
        private string server="localhost";
        private string database="gui_test";
        private string user = "";
        private string pw = "";
        private MySqlConnection connection = null;

        public DBMgr(string p_user, string p_password)
        {
            user = p_user;
            pw = p_password;
        }

        ~DBMgr()
        {
            pw = "";
        }

        private bool databaseConnect()
        {
            string con_str = "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + user + ";" +
                "PASSWORD=" + pw + ";";

            try
            {
                connection = new MySqlConnection(con_str);
                connection.Open();
            }
            catch (SqlException ex)
            {
                return false;
            }

            return true;
        }

        public string searchForValue(string Name)
        {
            return "";
        }

        public bool addEntry(string name, string value)
        {
            return false;
        }

        public bool editEntry(int key, string name, string value)
        {
            return false;
        }

        public bool deleteEntry(string name)
        {
            return false;
        }
    }
}
