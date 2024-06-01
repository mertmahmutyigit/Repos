using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
 
namespace Hafta2_form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b=(Button)sender; // hangi butona basıldıysa onun text i ni gösteriyor
                                     // textBox1.Text= b.Text;  textbox ta basılan butunları gösteriyor
            textBox1.Text = textBox1.Text + b.Text; // her basılan harfi textbox sa ekliyor
        }
    }
}
