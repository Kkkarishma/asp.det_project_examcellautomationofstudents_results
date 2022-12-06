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
    public partial class s_details : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataTable ds;
        string s;
        SqlCommandBuilder build;
        public s_details()
        {
            InitializeComponent();
        }


        private void s_details_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial Catalog=UIDExam;Integrated Security=true");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = "select * from STUD_REG";
            da = new SqlDataAdapter(s, cn);
            ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                build = new SqlCommandBuilder(da);
                da.Update(ds);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            

        }

      
    }

