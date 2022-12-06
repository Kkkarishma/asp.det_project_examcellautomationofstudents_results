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
    public partial class External_exam : Form
    {
        SqlConnection cn;
        SqlDataAdapter da, da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11;
        DataTable ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, ds9, ds10, ds11;
        string s;

        SqlCommandBuilder build;

        public External_exam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                s = "select UID,SC1,SN1,E1,SC2,SN2,E2,SC3,SN3,E3,SC4,SN4,E4,SC5,SN5,E5  from FIT";
                da = new SqlDataAdapter(s, cn);
                ds = new DataTable();
                da.Fill(ds);
                dataGridView1.DataSource = ds;

               
            }
            if (comboBox5.SelectedIndex == 0 && comboBox3.SelectedIndex == 1)
            {
                s = "select UID,SC6,SN6,E6,SC7,SN7,E7,SC8,SN8,E8,SC9,SN9,E9,SC10,SN10,E10  from FIT";
                da1 = new SqlDataAdapter(s, cn);
                ds1 = new DataTable();
                da1.Fill(ds1);
                dataGridView1.DataSource = ds1;

               
            }
            if (comboBox5.SelectedIndex == 1 && comboBox3.SelectedIndex == 2)
            {
                s = "select UID,SC1,SN1,E1,SC2,SN2,E2,SC3,SN3,E3,SC4,SN4,E4,SC5,SN5,E5  from SIT";
                da2 = new SqlDataAdapter(s, cn);
                ds2 = new DataTable();
                da2.Fill(ds2);
                dataGridView1.DataSource = ds2;

               
            }
            if (comboBox5.SelectedIndex == 1 && comboBox3.SelectedIndex == 3)
            {
                s = "select UID,SC6,SN6,E6,SC7,SN7,E7,SC8,SN8,E8,SC9,SN9,E9,SC10,SN10,E10  from SIT";
                da3 = new SqlDataAdapter(s, cn);
                ds3 = new DataTable();
                da3.Fill(ds3);
                dataGridView1.DataSource = ds3;

                
            }
            if (comboBox5.SelectedIndex == 2 && comboBox3.SelectedIndex == 4)
            {
                s = "select UID,SC1,SN1,E1,SC2,SN2,E2,SC3,SN3,E3,SC4,SN4,E4,SC5,SN5,E5  from TIT";
                da4 = new SqlDataAdapter(s, cn);
                ds4 = new DataTable();
                da4.Fill(ds4);
                dataGridView1.DataSource = ds4;

               
            }
            if (comboBox5.SelectedIndex == 2 && comboBox3.SelectedIndex == 5)
            {
                s = "select UID,SC6,SN6,E6,SC7,SN7,E7,SC8,SN8,E8,SC9,SN9,E9,SC10,SN10,E10  from TIT";
                da5 = new SqlDataAdapter(s, cn);
                ds5 = new DataTable();
                da5.Fill(ds5);
                dataGridView1.DataSource = ds5;

               

            }
            if (comboBox5.SelectedIndex == 3 && comboBox3.SelectedIndex == 0)
            {
                s = "select UID,SC1,SN1,E1,SC2,SN2,E2,SC3,SN3,E3,SC4,SN4,E4,SC5,SN5,E5  from FYCS";
                da6 = new SqlDataAdapter(s, cn);
                ds6 = new DataTable();
                da6.Fill(ds6);
                dataGridView1.DataSource = ds6;

            }
            if (comboBox5.SelectedIndex == 3 && comboBox3.SelectedIndex == 1)
            {
                s = "select UID,SC6,SN6,E6,SC7,SN7,E7,SC8,SN8,E8,SC9,SN9,E9,SC10,SN10,E10  from FYCS";
                da7 = new SqlDataAdapter(s, cn);
                ds7 = new DataTable();
                da7.Fill(ds7);
                dataGridView1.DataSource = ds7;

               
            }
            if (comboBox5.SelectedIndex == 4 && comboBox3.SelectedIndex == 2)
            {
                s = "select UID,SC1,SN1,E1,SC2,SN2,E2,SC3,SN3,E3,SC4,SN4,E4,SC5,SN5,E5  from SYCS";
                da8 = new SqlDataAdapter(s, cn);
                ds8 = new DataTable();
                da8.Fill(ds8);
                dataGridView1.DataSource = ds8;

               
            }
            if (comboBox5.SelectedIndex == 4 && comboBox3.SelectedIndex == 3)
            {
                s = "select UID,SC6,SN6,E6,SC7,SN7,E7,SC8,SN8,E8,SC9,SN9,E9,SC10,SN10,E10  from SYCS";
                da9 = new SqlDataAdapter(s, cn);
                ds9 = new DataTable();
                da9.Fill(ds9);
                dataGridView1.DataSource = ds9;

            }
            if (comboBox5.SelectedIndex == 5 && comboBox3.SelectedIndex == 4)
            {
                s = "select UID,SC1,SN1,E1,SC2,SN2,E2,SC3,SN3,E3,SC4,SN4,E4,SC5,SN5,E5  from TYCS";
                da10 = new SqlDataAdapter(s, cn);
                ds10 = new DataTable();
                da10.Fill(ds10);
                dataGridView1.DataSource = ds10;

            }
            if (comboBox5.SelectedIndex == 5 && comboBox3.SelectedIndex == 5)
            {
                s = "select UID,SC6,SN6,E6,SC7,SN7,E7,SC8,SN8,E8,SC9,SN9,E9,SC10,SN10,E10  from TYCS";
                da11 = new SqlDataAdapter(s, cn);
                ds11 = new DataTable();
                da11.Fill(ds11);
                dataGridView1.DataSource = ds11;

              

            }
        }

        private void External_exam_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial Catalog=UIDExam;Integrated Security=true");
            cn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox5.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                build = new SqlCommandBuilder(da);
                da.Update(ds);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 0 && comboBox3.SelectedIndex == 1)
            {

                build = new SqlCommandBuilder(da1);
                da1.Update(ds1);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 1 && comboBox3.SelectedIndex == 2)
            {
                build = new SqlCommandBuilder(da2);
                da2.Update(ds2);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 1 && comboBox3.SelectedIndex == 3)
            {

                build = new SqlCommandBuilder(da3);
                da3.Update(ds3);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 2 && comboBox3.SelectedIndex == 4)
            {
                build = new SqlCommandBuilder(da4);
                da4.Update(ds4);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 2 && comboBox3.SelectedIndex == 5)
            {
                build = new SqlCommandBuilder(da5);
                da5.Update(ds5);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 3 && comboBox3.SelectedIndex == 0)
            {

                build = new SqlCommandBuilder(da6);
                da6.Update(ds6);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 3 && comboBox3.SelectedIndex == 1)
            {

                build = new SqlCommandBuilder(da7);
                da7.Update(ds7);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 4 && comboBox3.SelectedIndex == 2)
            {

                build = new SqlCommandBuilder(da8);
                da8.Update(ds8);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 4 && comboBox3.SelectedIndex == 3)
            {
                build = new SqlCommandBuilder(da9);
                da9.Update(ds9);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 5 && comboBox3.SelectedIndex == 4)
            {
                build = new SqlCommandBuilder(da10);
                da10.Update(ds10);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
            if (comboBox5.SelectedIndex == 5 && comboBox3.SelectedIndex == 5)
            {
                build = new SqlCommandBuilder(da11);
                da11.Update(ds11);
                MessageBox.Show("RECORDS UPDATED SUCCESSFULLY ...!!!!!");
            }
        }


    }
}