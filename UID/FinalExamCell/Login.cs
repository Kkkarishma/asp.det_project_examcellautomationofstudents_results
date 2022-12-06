using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace FinalExamCell
{
    public partial class Login : Form
    {
        SqlDataAdapter da;
        SqlConnection cn;
        DataSet ds;
        String s;
        public static string a;

        public Login()
        {


            Thread t = new Thread(new ThreadStart(Form2));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

        }
        private void Form2()
        {
            Application.Run(new Login());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" & textBox2.Text == "")
            {
                MessageBox.Show("Please enter user ID and Password");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("please enter user ID");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("please enter password");
            }

            s = "select * from admin where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";

            da = new SqlDataAdapter(s, cn);
            ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                
                a = textBox1.Text;
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter correct User ID and Password");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial catalog=UIDExam;Integrated Security=true");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset_pwd r = new reset_pwd();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\windows\system32\osk.exe");
        }



    }
}


