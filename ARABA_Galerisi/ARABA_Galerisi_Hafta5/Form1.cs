using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARABA_Galerisi_Hafta5
{
    public partial class Form1 : Form
    {
        Galeri g;
        public Form1()
        {
            g = new Galeri();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string marka=textBox1.Text;
         short model=Convert.ToInt16(textBox2.Text);
         string renk = textBox3.Text;
          Araba a= new Araba(marka,model,renk);
          g.Arabaekle(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] s = g.arabalistele();
            for(int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i]);

            }

        }
    }
}
