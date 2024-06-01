using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta5_DOSYA_giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //MessageBox.Show("merhaba");
 String mesaj=textBox1.Text; //texbox 1 in içindekini al mesaja ata
            MessageBox.Show(mesaj);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
