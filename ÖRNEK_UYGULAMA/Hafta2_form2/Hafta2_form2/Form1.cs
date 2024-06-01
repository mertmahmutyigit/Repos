using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta2_form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( char.IsLetter(e.KeyChar) ||  char.IsWhiteSpace(e.KeyChar)) { e.Handled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = Convert.ToInt32(textBox1.Text);
            double kok = 1;
            int i = 0;
            while (true) {
                i = i + 1;
                kok = (sayı / kok + kok) / 2;
                if (i == sayı + 1) break;
             
            }
            textBox2.Text=kok.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
