using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta2_çoklubuton_bit_dönüşümü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string sayı=textBox1.Text;
            int say = Convert.ToInt32(sayı,2);
            label3.Text=Convert.ToString(say);*/

            string b=textBox1.Text;
            int sonuç = 0;
            for(int i = b.Length - 1; i >= 0; i--)
            {
                sonuç = sonuç + (int)(Math.Pow(2, b.Length - 1 - i)) * (int)(b[i] - '0');

            }  label3.Text=sonuç.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string yazıkalan = "";
            int kalan = 0;
            int sayı=Convert.ToInt32(textBox1.Text);
            while (sayı != 0)
            {
                kalan = sayı % 2;
                sayı = sayı / 2;

                yazıkalan = kalan.ToString() + yazıkalan;


            }
            label3.Text = yazıkalan;
        }

       
    }
}
