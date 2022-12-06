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
    public partial class individual_report : Form
    {
        public individual_report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection sc = new SqlConnection(@"Data Source=LAPTOP-F8V4H9CT\SQLEXPRESS;Initial catalog=UIDExam;Integrated Security=true");
            sc.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from STUD_REG", sc);
            da.Fill(ds, "STUD_REG");
         //   CrystalReport2 cr = new CrystalReport2();
           // cr.SetDataSource(ds.Tables["STUD_REG"]);

         //   crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Show();
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
