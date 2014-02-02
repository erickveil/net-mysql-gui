using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBMTest
{
    public partial class PWForm : Form
    {
        public string pw;

        public PWForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pw = tb_sql_pw.Text;
            this.Close();
        }

    }
}
