using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalExamCell
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sTUDENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void iNTERNALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Internal_exam i = new Internal_exam();
            i.Show();
        }

        private void eXTERNALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            External_exam e1 = new External_exam();
            e1.Show();
        }

        private void pRACTICALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pract_Exam p = new Pract_Exam();
            p.Show();
        }

        private void rEGISTRATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            S_Enroll s = new S_Enroll();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logout succesfully", "Logout", MessageBoxButtons.OKCancel);
            this.Close();
            Login l=new Login();
            l.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            percent p = new percent();
            p.Show();

        }

         
        private void uIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sTUDENTNAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void cALCULATORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

       

        private void rEGISTRATIONDEATILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s_details s1 = new s_details();
            s1.Show();
        }

        private void cLASSDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            class_Details c = new class_Details();
            c.Show();
        }

        
       
        private void cLASSREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result rt = new result();
            rt.Show();
        }

        private void cLASSREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            class_report cr = new class_report();
            cr.Show();
        }

        private void iTREPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            individual_report IN = new individual_report();
        }

        
        
          }
}
