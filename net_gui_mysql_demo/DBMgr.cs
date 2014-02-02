﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data.SqlTypes;

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
            databaseConnect();
        }

        ~DBMgr()
        {
            connection.Close();
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

        
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// string from the query result.<br/>
        /// returns empty string if null was saved in database for the result value.<br/>
        /// returns null if the query fails.<br/>
        /// </returns>
        public string searchForValue(string name)
        {
            string result = null;
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = connection;
            string placeholder = "@name";
            cmd.CommandText = "select value from test where name="+placeholder;
            cmd.Prepare();
            cmd.Parameters.AddWithValue(placeholder, name);

            try
            {
                result = (string)cmd.ExecuteScalar();
            }
            catch (System.InvalidCastException)
            {
                // if we fail to cast to string, it might be a null value in the db
                // so we accept this as legit and convert it to empty string
                // otherwise, it's considered an error and return null.
                if (cmd.ExecuteScalar() is DBNull)
                {
                    result = "";
                }
                else 
                { 
                    result = null; 
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool addEntry(string name, string value)
        {
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = connection;
            cmd.CommandText = "insert into test (name,value) values(@name,@value)";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@value", value);

            int rows_inserted = cmd.ExecuteNonQuery();

            if (rows_inserted == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
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
