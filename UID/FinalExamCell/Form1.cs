using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FinalExamCell
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);
            if (progressBar1.Value == 10)
                {
                    label1.Text = "Initializing....";
                }
                if (progressBar1.Value == 20)
                {
                    label1.Text = "Collecting information......";
                }
                if (progressBar1.Value == 40)
                {
                    label1.Text = "Processing Data...";
                }
                if (progressBar1.Value == 60)
                {
                    label1.Text = "Preparing Application...";
                }
                if (progressBar1.Value == 80)
                {
                    label1.Text = "Welcome to RTCCS Exam Cell....";
                }
                if (progressBar1.Value == 100)
                {
                timer1.Stop();
               
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
       
            
        }    }

        
    

