﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta5_nesne_Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void degistr(Class1 p) {

            p.ad = p.ad.ToUpper();
            p.soyad = p.soyad.ToUpper();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c=new Class1();
            c.ad=textBox1.Text;
            c.soyad=textBox2.Text;
            degistr(c);
            textBox1.Text = c.ad;
            textBox2.Text = c.soyad;

        }
    }
}
