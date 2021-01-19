using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03p01_cykl_zycia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Zdarzenie ACTIVATE \n";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Zdarzenie DEACTIVATE \n";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Zdarzenie SHOWN \n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Zdarzenie LOAD \n";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Zdarzenie ClOSED");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Zdarzenie ClOSING");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text +
                Form1.ActiveForm.Width.ToString() + "-" + Form1.ActiveForm.Height.ToString()+ "\n";
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Zdarzenie MOVE \n";
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Zdarzenie RESIZE BEGIN \n";
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "Zdarzenie RESIZE END \n";
        }
    }
}
