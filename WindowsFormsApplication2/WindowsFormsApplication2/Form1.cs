using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //aqui indicamos que se visualice el ventana de todos los procesos
        public Form1()
        {
            InitializeComponent();
        }
        //aqui se inica el primer proceso

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar t = new ProgressBar();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          

            progressBar1.Value = progressBar1.Value + 1;
            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
            progressBar1.Style = ProgressBarStyle.Continuous;
            if (Convert.ToInt32(progressBar1.Value) == 100)
            {
                timer1.Stop();
                timer1.Enabled = false;
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        
        //aqui se inician todos los procesos
        private void btnincrementar_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.timer2.Start();
            this.timer3.Start();
            this.timer4.Start();
        }
        //aqui se pausan todos los procesos
        private void btnpausar_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer2.Stop();
            this.timer3.Stop();
            this.timer4.Stop();
        }

        
        //este es donde se cierra el programa 
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //aqui se inicia el proceso 2
        private void progressBar2_Click(object sender, EventArgs e)
        {
            ProgressBar pBar2 = new ProgressBar();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            {
              progressBar2.Value = progressBar2.Value + 1;
                label2.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                progressBar2.Style = ProgressBarStyle.Continuous;
                if (Convert.ToInt32(progressBar2.Value) == 100)
                {
                    timer2.Stop();
                    timer2.Enabled = false;
                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
        }
        //aqui se inicia el proceso 3
        private void progressBar3_Click(object sender, EventArgs e)
        {
            ProgressBar pBar3 = new ProgressBar();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            {
                progressBar3.Value = progressBar3.Value + 1;
                label3.Text = (Convert.ToInt32(label3.Text) + 1).ToString();
                progressBar3.Style = ProgressBarStyle.Continuous;
                if (Convert.ToInt32(progressBar3.Value) == 100)
                {
                    timer3.Stop();
                    timer3.Enabled = false;
                    Form4 form4 = new Form4();
                    form4.Show();
                }
            }
        }
        private void progressBar4_Click(object sender, EventArgs e)
        {
            ProgressBar pBar4 = new ProgressBar();
        }
        //aqui se incia el ultimo proceso
        private void timer4_Tick(object sender, EventArgs e)
        {
            {
                progressBar4.Value = progressBar4.Value + 1;
                label4.Text = (Convert.ToInt32(label4.Text) + 1).ToString();
                progressBar4.Style = ProgressBarStyle.Continuous;
                if (Convert.ToInt32(progressBar4.Value) == 100)
                {
                    timer4.Stop();
                    timer4.Enabled = false;
                    Form5 form5 = new Form5();
                    form5.Show();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
