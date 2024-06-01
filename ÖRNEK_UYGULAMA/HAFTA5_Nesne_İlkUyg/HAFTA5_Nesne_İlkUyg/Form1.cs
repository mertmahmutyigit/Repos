using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAFTA5_Nesne_İlkUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void personelbilgi(personel p)
        {
            p.isim = p.isim.ToUpper();
            p.soyisim=p.soyisim.ToUpper();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            personel p = new personel();
            p.isim = textBox1.Text;
            p.soyisim = textBox2.Text;
            personelbilgi(p);
            textBox1.Text = p.isim;
            textBox2.Text = p.soyisim;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            işçi g = new işçi();
            g.KimlikNo=Convert.ToInt32(textBox3.Text);
            MessageBox.Show("girilen kimlik no = " + g.KimlikNo);

        }
    }
}
