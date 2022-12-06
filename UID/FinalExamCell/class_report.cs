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
    public partial class class_report : Form
    {
        public class_report()
        {
            InitializeComponent();
        }

        private void class_report_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial catalog=UIDExam;Integrated Security=true");
            sc.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from RESULTS,STUD_REG", sc);
            da.Fill(ds,"RESULTS,STUD_REG");
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds.Tables["RESULTS,STUD_REG"]);

            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Show();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
