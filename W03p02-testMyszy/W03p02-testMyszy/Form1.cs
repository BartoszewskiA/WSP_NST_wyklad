using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03p02_testMyszy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "x= "+ e.X.ToString() + "  Y= " + e.Y.ToString();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                    panel1.BackColor = Color.Green;
            else if (e.Button ==MouseButtons.Right)
                    panel2.BackColor = Color.Green;
            else if(e.Button==MouseButtons.Middle)
                    panel3.BackColor = Color.Green;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.LightGray;
            panel2.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "ENTER \n";
            panel4.BackColor = Color.Aqua;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "HOVER \n";
            //panel4.BackColor = Color.Aqua;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "LEVE \n";
            panel4.BackColor = Color.LightGray;
        }
    }
}
