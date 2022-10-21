using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public int dakika = 0, saniye = 0, salise = 0;
        bool durum=true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ("dakika: " + lbdakika.Text + "saniye: " + lbsaniye.Text + "salise: " + lbsalise.Text + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbdakika.Text = "0";
            lbsaniye.Text = "0";
            lbsalise.Text = "0";
            timer1.Stop();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (durum == true)
            {
                timer1.Start();
                durum = false;
            }
            else
            {
                timer1.Stop();
                durum = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            salise++;

            if (salise == 60)
            {
                saniye++;
                salise = 0;
            }
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            if (dakika == 60)
            {
                
                dakika = 0;
            }
            if (saniye == 60 && dakika == 59 && salise == 0)
            {
                saniye = 0;
                dakika = 0;
                
            }
            lbsalise.Text = salise.ToString();
            lbsaniye.Text = saniye.ToString();
            lbdakika.Text = dakika.ToString();
            

        }
    }
}
