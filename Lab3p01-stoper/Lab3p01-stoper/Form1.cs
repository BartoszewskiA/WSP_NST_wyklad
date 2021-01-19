using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3p01_stoper
{
    public partial class Form1 : Form
    {
        private int ds = 0;
        private int s = 0;
        private int m = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ds < 9)
            {
                ds++;
                label1.Text = ds.ToString();
            }
            else
            {
                ds = 0;
                label1.Text = ds.ToString();
                if (s < 59)

                {
                    s++;
                    label2.Text = s.ToString();
                }
                else
                {
                    s = 0;
                    label2.Text = s.ToString();
                    m++;
                    label3.Text = m.ToString();
                }
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
                button1.Text = "PAUZA";
            }
            else
            {
                timer1.Stop();
                button1.Text = "START";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ds = 0;
            s = 0;
            m = 0;
            label1.Text = ds.ToString();
            label2.Text = s.ToString();
            label3.Text = m.ToString();
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + m.ToString() + " : "
                                                  + s.ToString() + " : "
                                                  + ds.ToString() + "\n";
        }
    }
}
