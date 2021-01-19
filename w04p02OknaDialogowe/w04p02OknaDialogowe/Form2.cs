using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04p02OknaDialogowe
{
    
    public partial class Form2 : Form
    {
        Random random;
        public int liczbalosowa;
        public Form2()
        {
            InitializeComponent();
            random = new Random();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            liczbalosowa = random.Next(1000);
        }
    }
}
