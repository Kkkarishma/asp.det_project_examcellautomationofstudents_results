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
    public partial class percent : Form
    {
        SqlConnection sc;
        SqlCommand cmd;

        public percent()
        {
            InitializeComponent();
        }

        int s1, s2, s3, s4, s5, tot, avg;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter the marks of subject 1");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please Enter the marks of subject 2");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Please Enter the marks of subject 3");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please Enter the marks of subject 4");
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("Please Enter the marks of subject 5");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please the student UID");
                return;
            }
            if (textBox11.Text == "")
            {
                MessageBox.Show("Please enter the semester");
                return;
            }
            if (textBox12.Text == "")
            {
                MessageBox.Show("Please enter the name of student");
                return;
            }



            s1 = int.Parse(textBox3.Text);
            s2 = int.Parse(textBox4.Text);
            s3 = int.Parse(textBox5.Text);
            s4 = int.Parse(textBox6.Text);
            s5 = int.Parse(textBox7.Text);

            tot = s1 + s2 + s3 + s4 + s5;
            textBox2.Text = tot.ToString();

            avg = tot / 5;
            textBox8.Text = avg.ToString();

            if(avg>70)
            {
                textBox9.Text="O";
                textBox10.Text="7";
                label15.Text = "SUCCESSFUL";
            }
            else if (avg > 60)
            {
                textBox9.Text = "A";
                textBox10.Text = "6";
                label15.Text = "SUCCESSFUL";
            }
            else if (avg > 55)
            {
                textBox9.Text = "B";
                textBox10.Text = "5";
                label15.Text = "SUCCESSFUL";
            }
            else if (avg > 50)
            {
                textBox9.Text = "C";
                textBox10.Text = "4";
                label15.Text = "SUCCESSFUL";

            }
            else if (avg > 45)
            {
                textBox9.Text = "D";
                textBox10.Text = "3";
                label15.Text = "SUCCESSFUL";
            }
            else if (avg > 40)
            {
                textBox9.Text = "E";
                textBox10.Text = "2";
                label15.Text = "SUCCESSFUL";
            }
            else if (avg < 39)
            {
                textBox9.Text = "F";
                textBox10.Text = "1";
                label15.Text = "UNSUCCESSFUL";
            }
}


        private void percent_Load(object sender, EventArgs e)
        {
            sc = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial Catalog=UIDExam;Integrated Security=true");
            sc.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox12.Text == "" && textBox11.Text == "")
            {
                MessageBox.Show("please fill the fields ...");
                return;
            }
            cmd = new SqlCommand("Insert into RESULTS (UID,S_NAME,SEM_NO,TOT,AVG,GRADE,GRADE_P) values('" +textBox1.Text+"','"+textBox12.Text+"','"+textBox11.Text+"','"+textBox2.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox10.Text+"')",sc);
            cmd.ExecuteNonQuery();
            MessageBox.Show("RECPRDS INCERTED SUCCESSFULLY.....!!!!!!!!");
        }

       
    }
}
