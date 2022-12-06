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
    public partial class class_Details : Form
    {

        SqlConnection cn;
        SqlDataAdapter da, da1, da2,da3,da4,da5;
        DataTable ds, ds1, ds2,ds3,ds4,ds5;
        string s, p, q;
        public class_Details()
        {
            InitializeComponent();
        }

        private void class_Details_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial Catalog=UIDExam;Integrated Security=true");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                s = "select * from FIT";
                da = new SqlDataAdapter(s, cn);
                ds = new DataTable();
                da.Fill(ds);
                dataGridView1.DataSource = ds;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                p = "select * from SIT";
                da1 = new SqlDataAdapter(p, cn);
                ds1 = new DataTable();
                da1.Fill(ds1);
                dataGridView1.DataSource = ds1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                q = "select * from TIT";
                da2 = new SqlDataAdapter(q, cn);
                ds2 = new DataTable();
                da2.Fill(ds2);
                dataGridView1.DataSource = ds2;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                q = "select * from FYCS";
                da3 = new SqlDataAdapter(q, cn);
                ds3 = new DataTable();
                da3.Fill(ds3);
                dataGridView1.DataSource = ds3;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                q = "select * from SYCS";
                da4 = new SqlDataAdapter(q, cn);
                ds4 = new DataTable();
                da4.Fill(ds4);
                dataGridView1.DataSource = ds4;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                q = "select * from TYCS";
                da5 = new SqlDataAdapter(q, cn);
                ds5 = new DataTable();
                da5.Fill(ds5);
                dataGridView1.DataSource = ds5;
            }
            else
            {
                MessageBox.Show("wrong selection...");
            }

        } 
 
        }


}
    
