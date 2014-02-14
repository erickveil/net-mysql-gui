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

        public delegate void SetTextCallback(string text);

        public void setText(string text)
        {
            tb_search_value.Text = text;
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
                        "Failed to find entry. Make sure the MySQL Server is running, and that the correct user name and address are entered.");
                }
                else
                {
                    if (tb_search_value.InvokeRequired)
                    {
                        SetTextCallback text_callback = setText;
                        Invoke(text_callback, new object[] {query_result});
                    }
                    else
                    {
                        tb_search_value.Text = query_result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bu_add_Click(object sender, EventArgs e)
        {
            if (tb_add_name.Text == "" || tb_add_value.Text == "")
            {
                MessageBox.Show("Make sure you have entered a name and value in the boxes.");
                return;
            }
            
            db_thread = new Thread(runDBAdd) { IsBackground = true };
            db_thread.Start();

        }

        private void runDBAdd()
        {
            try
            {
                db = new DBMgr(tb_mysql_user.Text, tb_mysql_pw.Text);
                if (!db.addEntry(tb_add_name.Text, tb_add_value.Text))
                {
                    MessageBox.Show(
                        "Failed to add entry to database. Make sure the MySQL Server is running, and that the correct user name and address are entered.");
                }
                else
                {
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
