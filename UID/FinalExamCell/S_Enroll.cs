using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace FinalExamCell
{
    public partial class S_Enroll : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        string gender;
        string cast;
        string course;
        string year;
        SqlDataReader dr;
        int a;
       
        public S_Enroll()
        {
            InitializeComponent();
           
        }
        private void S_Enroll_Load(object sender, EventArgs e)
        {
          
            cn = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial Catalog=UIDExam;Integrated Security=True");
            cn.Open();


            string sql = "Select Max(UID) from STUD_REG";
            cmd = new SqlCommand(sql, cn);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox9.Text = "101";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox9.Text = a.ToString();
                }
                dr.Close();
            }

        }

      
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            course = "IT";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            course = "CS";
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            year = "FIRST";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            year = "SECOND";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            year = "THIRD";
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            cast = "open";
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            cast = "obc";
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            cast = "sc/st";
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            cast = "nt";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "female";
        }


              private void button1_Click_1(object sender, EventArgs e)
        {

            

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select the course!");
                return;
            }

            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Please select the gender!");
                return;
            }
            if (!radioButton6.Checked && !radioButton5.Checked && !radioButton7.Checked && radioButton8.Checked)
            {
                MessageBox.Show("Please select the cast!");
                return;

            }

            if (!radioButton9.Checked && !radioButton10.Checked && !radioButton11.Checked)
            {
                MessageBox.Show("Please select the year!");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Please Enter the UID");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter the roll no:");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please Enter the first name");
                return;
            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("Please Enter the mother's name");
                return;
            }
            if (textBox11.Text == "")
            {
                MessageBox.Show("Please Enter the last name");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter the seat number");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter the middle name");
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Please Enter the year of admission");
                return;
            }

            try
            {

                cmd = new SqlCommand("Insert into STUD_REG (UID,RNO,SEATNO,GENDER,FNAME,FANAME,MNAME,LNAME,YOADMIN,COURSE,SPECIFY,CAST) values('" + textBox9.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + gender + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox5.Text + "','" + course + "','" + year + "','" + cast + "')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Student is added");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
              
            cn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
        }

        
    }
