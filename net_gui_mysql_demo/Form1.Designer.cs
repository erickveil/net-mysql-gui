namespace net_gui_mysql_demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_mysql_pw = new System.Windows.Forms.TextBox();
            this.tb_mysql_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_delete_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bu_delete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_edit_value = new System.Windows.Forms.TextBox();
            this.tb_edit_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bu_edit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_search_value = new System.Windows.Forms.TextBox();
            this.tb_search_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bu_search = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_add_value = new System.Windows.Forms.TextBox();
            this.tb_add_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bu_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_mysql_pw);
            this.groupBox1.Controls.Add(this.tb_mysql_user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // tb_mysql_pw
            // 
            this.tb_mysql_pw.Location = new System.Drawing.Point(82, 45);
            this.tb_mysql_pw.Name = "tb_mysql_pw";
            this.tb_mysql_pw.PasswordChar = '*';
            this.tb_mysql_pw.Size = new System.Drawing.Size(100, 20);
            this.tb_mysql_pw.TabIndex = 3;
            // 
            // tb_mysql_user
            // 
            this.tb_mysql_user.Location = new System.Drawing.Point(82, 19);
            this.tb_mysql_user.Name = "tb_mysql_user";
            this.tb_mysql_user.Size = new System.Drawing.Size(100, 20);
            this.tb_mysql_user.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MySQL User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_delete_name);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bu_delete);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // tb_delete_name
            // 
            this.tb_delete_name.Location = new System.Drawing.Point(82, 19);
            this.tb_delete_name.Name = "tb_delete_name";
            this.tb_delete_name.ReadOnly = true;
            this.tb_delete_name.Size = new System.Drawing.Size(100, 20);
            this.tb_delete_name.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Name";
            // 
            // bu_delete
            // 
            this.bu_delete.Location = new System.Drawing.Point(63, 45);
            this.bu_delete.Name = "bu_delete";
            this.bu_delete.Size = new System.Drawing.Size(75, 23);
            this.bu_delete.TabIndex = 0;
            this.bu_delete.Text = "Delete";
            this.bu_delete.UseVisualStyleBackColor = true;
            this.bu_delete.Click += new System.EventHandler(this.bu_delete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_edit_value);
            this.groupBox3.Controls.Add(this.tb_edit_name);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.bu_edit);
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit";
            // 
            // tb_edit_value
            // 
            this.tb_edit_value.Location = new System.Drawing.Point(82, 45);
            this.tb_edit_value.Name = "tb_edit_value";
            this.tb_edit_value.Size = new System.Drawing.Size(100, 20);
            this.tb_edit_value.TabIndex = 4;
            // 
            // tb_edit_name
            // 
            this.tb_edit_name.Location = new System.Drawing.Point(82, 19);
            this.tb_edit_name.Name = "tb_edit_name";
            this.tb_edit_name.Size = new System.Drawing.Size(100, 20);
            this.tb_edit_name.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name";
            // 
            // bu_edit
            // 
            this.bu_edit.Location = new System.Drawing.Point(63, 69);
            this.bu_edit.Name = "bu_edit";
            this.bu_edit.Size = new System.Drawing.Size(75, 23);
            this.bu_edit.TabIndex = 0;
            this.bu_edit.Text = "Edit";
            this.bu_edit.UseVisualStyleBackColor = true;
            this.bu_edit.Click += new System.EventHandler(this.bu_edit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_search_value);
            this.groupBox4.Controls.Add(this.tb_search_name);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.bu_search);
            this.groupBox4.Location = new System.Drawing.Point(216, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 132);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // tb_search_value
            // 
            this.tb_search_value.Location = new System.Drawing.Point(88, 47);
            this.tb_search_value.Name = "tb_search_value";
            this.tb_search_value.ReadOnly = true;
            this.tb_search_value.Size = new System.Drawing.Size(100, 20);
            this.tb_search_value.TabIndex = 4;
            // 
            // tb_search_name
            // 
            this.tb_search_name.Location = new System.Drawing.Point(88, 19);
            this.tb_search_name.Name = "tb_search_name";
            this.tb_search_name.Size = new System.Drawing.Size(100, 20);
            this.tb_search_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Search Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search Name";
            // 
            // bu_search
            // 
            this.bu_search.Location = new System.Drawing.Point(63, 73);
            this.bu_search.Name = "bu_search";
            this.bu_search.Size = new System.Drawing.Size(75, 23);
            this.bu_search.TabIndex = 0;
            this.bu_search.Text = "Search";
            this.bu_search.UseVisualStyleBackColor = true;
            this.bu_search.Click += new System.EventHandler(this.bu_search_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_add_value);
            this.groupBox5.Controls.Add(this.tb_add_name);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.bu_add);
            this.groupBox5.Location = new System.Drawing.Point(216, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(198, 126);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add";
            // 
            // tb_add_value
            // 
            this.tb_add_value.Location = new System.Drawing.Point(88, 46);
            this.tb_add_value.Name = "tb_add_value";
            this.tb_add_value.Size = new System.Drawing.Size(100, 20);
            this.tb_add_value.TabIndex = 4;
            // 
            // tb_add_name
            // 
            this.tb_add_name.Location = new System.Drawing.Point(88, 19);
            this.tb_add_name.Name = "tb_add_name";
            this.tb_add_name.Size = new System.Drawing.Size(100, 20);
            this.tb_add_name.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // bu_add
            // 
            this.bu_add.Location = new System.Drawing.Point(63, 71);
            this.bu_add.Name = "bu_add";
            this.bu_add.Size = new System.Drawing.Size(75, 23);
            this.bu_add.TabIndex = 0;
            this.bu_add.Text = "Add";
            this.bu_add.UseVisualStyleBackColor = true;
            this.bu_add.Click += new System.EventHandler(this.bu_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 296);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MySQL GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_mysql_pw;
        private System.Windows.Forms.TextBox tb_mysql_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_delete_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bu_delete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_edit_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bu_edit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_search_value;
        private System.Windows.Forms.TextBox tb_search_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bu_search;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_add_value;
        private System.Windows.Forms.TextBox tb_add_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bu_add;
        private System.Windows.Forms.TextBox tb_edit_value;
    }
}

