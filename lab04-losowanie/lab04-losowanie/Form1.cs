using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_losowanie
{
    public partial class Form1 : Form
    {
        Random random;
        public int x = 0;

        Form2 form2;
        
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            random = new Random();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = hScrollBar2.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            
            if (b>a)
            {
                x = random.Next(a, b);
                //button1.Text = x.ToString();
                form2.label1.Text = x.ToString();
                form2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Zły zakres");
            }
            
        }
    }
}
