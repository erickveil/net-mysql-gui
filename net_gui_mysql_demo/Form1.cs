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
            db = new DBMgr(tb_mysql_user.Text, tb_mysql_pw.Text);
            if (!db.addEntry(tb_add_name.Text, tb_add_value.Text))
            {
                MessageBox.Show("Failed to add entry to database. Make sure the MySQL Server is running, and that the correct user name and address are entered.");
            }
            else
            {
                MessageBox.Show("The entry for " + tb_add_name.Text + " and " + tb_add_value.Text + " have been added.");
            }
        }


    }
}
