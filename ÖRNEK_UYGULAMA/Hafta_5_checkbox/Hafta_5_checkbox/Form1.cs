using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_5_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            if (checkBox1.Checked) toplam = toplam + 100;
            if (checkBox2.Checked) toplam = toplam + 200;
            if (checkBox3.Checked) toplam = toplam + 500;
            label2.Text = toplam.ToString();
        }
    }
}
