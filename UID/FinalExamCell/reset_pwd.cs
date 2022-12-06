using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;



namespace FinalExamCell
{
    public partial class reset_pwd : Form
    {
        
        SqlConnection cn;
       
     
        string st1;
        

        public reset_pwd()
        {
            InitializeComponent();
        }

        private void reset_pwd_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial catalog=UIDExam;Integrated Security=true");
            cn.Open();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int RowsAffected = 0;
                if ((textBox1.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter username", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if ((textBox2.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter old password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if ((textBox3.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please enter new password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if ((textBox4.Text.Trim().Length == 0))
                {
                    MessageBox.Show("Please confirm new password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                if ((textBox3.TextLength < 5))
                {
                    MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox4.Focus();
                    return;
                }
                else if ((textBox3.Text != textBox4.Text))
                {
                    MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox2.Focus();
                    return;
                }
                else if ((textBox2.Text == textBox3.Text))
                {
                    MessageBox.Show("Password is same..Re-enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox3.Focus();
                    return;
                }


                string co = "Update admin set password = '" + textBox4.Text + "'where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";

                if ((RowsAffected > 0))
                {
                    st1 = textBox1.Text;


                    MessageBox.Show("Successfully changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    Login l = new Login();
                    this.Hide();
                    Login ll = new Login();

                    ll.Show();
                }
                else
                {
                    MessageBox.Show("invalid user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }


}