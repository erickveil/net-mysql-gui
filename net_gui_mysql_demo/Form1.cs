using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace net_gui_mysql_demo
{
    public partial class Form1 : Form
    {
        private Thread db_thread;
        private DBMgr db;
        private Object locker = new Object();
        private long last_key;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bu_delete_Click(object sender, EventArgs e)
        {

        }

        private void bu_edit_Click(object sender, EventArgs e)
        {

        }

        private void bu_search_Click(object sender, EventArgs e)
        {

            if (tb_search_name.Text == "")
            {
                MessageBox.Show("The search box is empty.");
                return;
            }

            db_thread = new Thread(runDbSearch) { IsBackground = true };
            db_thread.Start();
        }

        /// <summary>
        /// Used for cross-thread search result invoke.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private delegate void SetTextCallback(string name, string value);

        /// <summary>
        /// After a search, fill in all necessary result fields.
        /// The search fills in fields for other functions so that they know
        /// what they are operating on and that it is legit data.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void setText(string name, string value)
        {
            tb_search_value.Text = value;
            tb_delete_name.Text = name;
            tb_edit_name.Text = name;
            tb_edit_value.Text = value;
            last_key = db.last_key;
        }

        private void runDbSearch()
        {
            try
            {
                db = new DBMgr(tb_mysql_user.Text, tb_mysql_pw.Text);
                string query_result = db.searchForValue(tb_search_name.Text);
                if (query_result == null)
                {
                    MessageBox.Show(
                        "Failed to find entry. Make sure the MySQL Server is "+
                        "running, and that the correct user name and "+
                        "address are entered.");
                }
                else
                {
                    threadSafeReport(query_result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void threadSafeReport(string query_result)
        {
            if (tb_search_value.InvokeRequired)
            {
                SetTextCallback text_callback = setText;
                Invoke(
                    text_callback, 
                    new object[]{tb_search_name.Text, query_result});
            }
            else
            {
                tb_search_value.Text = query_result;
            }
        }

        private void bu_add_Click(object sender, EventArgs e)
        {
            if (tb_add_name.Text == "" || tb_add_value.Text == "")
            {
                MessageBox.Show(
                    "Make sure you have entered a name and value in the "+
                    "boxes.");
                return;
            }
            
            db_thread = new Thread(runDbAdd) { IsBackground = true };
            db_thread.Start();

        }

        private void runDbAdd()
        {
            try
            {
                db = new DBMgr(tb_mysql_user.Text, tb_mysql_pw.Text);
                if (!db.addEntry(tb_add_name.Text, tb_add_value.Text))
                {
                    MessageBox.Show(
                        "Failed to add entry to database. Make sure the "+
                        "MySQL Server is running, and that the correct user "+
                        "name and address are entered.");
                }
                else
                {
                    last_key = db.last_key;
                    MessageBox.Show(
                        "The entry for " + tb_add_name.Text + " and " +
                        tb_add_value.Text + " have been added.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
