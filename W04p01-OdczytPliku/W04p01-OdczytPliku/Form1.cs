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

namespace W04p01_OdczytPliku
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> lista = new List<string>();
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                                FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                //richTextBox1.Text = sr.ReadToEnd();
                while (!sr.EndOfStream)
                {
                    lista.Add(sr.ReadLine());
                }
                sr.Close();

                richTextBox1.Lines = lista.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>(richTextBox1.Lines);
            
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName,
                                               FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                //sw.WriteLine("Tekst do zapisania");
                for (int i=0; i<lista.Count(); i++)
                {
                    sw.WriteLine(lista[i]);
                }


                sw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>(richTextBox1.Lines);

            for (int i=0; i<lista.Count(); i++)
            {
                if (lista[i].Length == 0)
                {
                    lista.RemoveAt(i);
                    i--;
                }

            }


            richTextBox1.Lines = lista.ToArray();

        }
    }
}
