using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAFTA5__ARABA_GALERİSİ
{
    public partial class Form1 : Form
    {
        Gleri g; 
        public Form1()
        {
         g=  new Gleri();
          

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marka = textBox1.Text;
            string model= textBox1.Text;
            string renk = textBox3.Text;
            araba a = new araba(marka,model,renk);
            g.arabaekle(a);
            MessageBox.Show("EKLEME YAPILDI");
        }
    }
}
