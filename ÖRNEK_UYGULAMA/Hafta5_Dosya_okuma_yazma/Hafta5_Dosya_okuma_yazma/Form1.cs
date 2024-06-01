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

namespace Hafta5_Dosya_okuma_yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\MERT MAHMUT YİĞİT\\Desktop\\text.txt");

            using (writer)
            {
                writer.WriteLine(textBox1.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:\\Users\\MERT MAHMUT YİĞİT\\Desktop\\text.txt");
            using (reader)
            {

                string satır = reader.ReadLine();
                while (satır != null)
                {
                    textBox1.Text = satır;
                    satır = reader.ReadLine();
                }
            }
        }
    }
}