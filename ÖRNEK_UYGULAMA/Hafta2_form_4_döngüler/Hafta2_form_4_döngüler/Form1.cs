using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta2_form_4_döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)|| char.IsPunctuation(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ){
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int n1= Convert.ToInt32(textBox1.Text);
            int n2= Convert.ToInt32(textBox2.Text);
            int i = 2;
         while(n1!=n2) {
                if (n1 > n2) n1 -= n2;
                else n2 -= n1;
            
            }
            Form1.ActiveForm.Text = "Enbüyük Ortak Bölen : " + n1;
            label4.Text = Convert.ToString(n1);
        }
    }
}
