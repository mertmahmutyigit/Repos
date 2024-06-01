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

namespace Hafta_5_Öğreci_kayıt_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\MERT MAHMUT YİĞİT\\Desktop\\Yeni klasör\\" + textBox1.Text + " " + textBox2.Text + ".txt ");
            using(writer) {
                writer.WriteLine(label1.Text + " " + textBox1.Text);
                writer.WriteLine(label2.Text + " " + textBox2.Text);
                writer.WriteLine(label3.Text + " " + textBox3.Text);
            }
            StreamReader reader = new StreamReader("C:\\Users\\MERT MAHMUT YİĞİT\\Desktop\\Yeni klasör\\" + textBox1.Text + " " + textBox2.Text + ".txt ");
            textBox4.Text=reader.ReadToEnd();
        }
    }
}
