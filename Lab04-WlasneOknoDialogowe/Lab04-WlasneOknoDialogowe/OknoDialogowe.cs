using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_WlasneOknoDialogowe
{
    public partial class OknoDialogowe : Form
    {
        public OknoDialogowe()
        {
            InitializeComponent();
        }

        private void OknoDialogowe_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
