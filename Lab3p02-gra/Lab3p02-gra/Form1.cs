using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3p02_gra
{
    public partial class Form1 : Form
    {

        Random random;
        int zielony = 0;
        int czerwony = 0;
        int punkty = 100;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.Beige;
            panel2.BackColor = Color.Beige;
            panel3.BackColor = Color.Beige;
            panel4.BackColor = Color.Beige;
            int x;
            do
            {
                x = random.Next(1, 5);
            } while (x == zielony);
            czerwony = x;
            do
            {
                x = random.Next(1, 5);
            } while (x == zielony || x==czerwony);
            zielony = x;
            
            switch (czerwony)
            {
                case 1: panel1.BackColor = Color.Red; break;
                case 2: panel2.BackColor = Color.Red; break;
                case 3: panel3.BackColor = Color.Red; break;
                case 4: panel4.BackColor = Color.Red; break;
            }
            switch (zielony)
            {
                case 1: panel1.BackColor = Color.Green; break;
                case 2: panel2.BackColor = Color.Green; break;
                case 3: panel3.BackColor = Color.Green; break;
                case 4: panel4.BackColor = Color.Green; break;
            }
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            punkty--;
            label1.Text = punkty.ToString();
            if (punkty<=0)
            {
                timer1.Stop();
                timer2.Stop();
                label2.Visible = true;
            }
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            if (zielony == 3) timer2.Stop();
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            if (zielony == 4) timer2.Stop();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            if (zielony == 1) timer2.Stop();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            if (zielony == 2) timer2.Stop();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if (czerwony == 3)
            {
                timer1.Stop();
                timer2.Stop();
                label2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (czerwony == 4)
            {
                timer1.Stop();
                timer2.Stop();
                label2.Visible = true;
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (czerwony == 1)
            {
                timer1.Stop();
                timer2.Stop();
                label2.Visible = true;
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (czerwony == 2)
            {
                timer1.Stop();
                timer2.Stop();
                label2.Visible = true;
            }
        }
    }
}
