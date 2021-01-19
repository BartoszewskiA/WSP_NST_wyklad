using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_WlasneOknoDialogowe
{
    public partial class Form1 : Form
    {

        OknoDialogowe oknoDialogowe;
        public Form1()
        {
            InitializeComponent();
            oknoDialogowe = new OknoDialogowe();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (oknoDialogowe.ShowDialog()==DialogResult.OK)
            {
                List<string> lista = new List<string>(richTextBox1.Lines);
                
                String s = "";
                s += oknoDialogowe.textBox1.Text;
                s += ";";
                s += oknoDialogowe.textBox2.Text;
                s += ";";
                s += oknoDialogowe.textBox3.Text;
                s += ";";
                lista.Add(s);
                richTextBox1.Lines = lista.ToArray();
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                List<string> lista = new List<string>(richTextBox1.Lines);
                FileStream fs = new FileStream(saveFileDialog1.FileName,
                                                FileMode.OpenOrCreate,
                                                FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < lista.Count(); i++)
                {
                    sw.WriteLine(lista[i]);
                }
                sw.Close();
            }

        }

        private void wczytajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                List<string> lista = new List<string>();
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                                FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    lista.Add(sr.ReadLine());
                }
                richTextBox1.Lines = lista.ToArray();
                sr.Close();
            }
        }
    }
}
