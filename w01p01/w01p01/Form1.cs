using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w01p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, temp;
            //x = int.Parse(textBox1.Text);   - bez zabespieczeń
            //y = int.Parse(textBox2.Text);
            if (int.TryParse(textBox1.Text, out temp))
                x = temp;
            else
                x = 0;
            if (int.TryParse(textBox2.Text, out temp))
                y = temp;
            else
                y = 0;
            int wynik = x + y;
            label1.Text = wynik.ToString();

            //label1.Text = (x + y).ToString();
        }
    }
}
