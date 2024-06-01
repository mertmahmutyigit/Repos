using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta1_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean Dogrula(){

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                return true;
            }
            catch (Exception) { return false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                int sayı1 = Convert.ToInt32(textBox1.Text);
                int sayı2 = Convert.ToInt32(textBox2.Text);
                MessageBox.Show("Toplam " + (sayı1 + sayı2));
            }
            else
            {

                MessageBox.Show("GİRİLEN DEĞERLERDE HATA VAR !");

            }
        
        }
    }
}
