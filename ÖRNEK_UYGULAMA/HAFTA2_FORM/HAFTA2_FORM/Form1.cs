using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HAFTA2_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) ||
                    char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar)) { 
            
            e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı = listBox2.Items.Count;
            if(sayı>0)
            {
                int enb = Convert.ToInt32(listBox2.Items[0]);
                int enk = Convert.ToInt32(listBox2.Items[0]);
                for(int i=1;i<sayı;i++)
                {
                    int alınan = Convert.ToInt32(listBox2.Items[i]);

                    if (alınan > enb) enb = alınan;
                    if (alınan <enk) enk = alınan;
                }
                MessageBox.Show("en büyük sayı " + enb + "  en küçük sayı  " + enk);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex!=-1) listBox2.Items.Remove(listBox2.SelectedItems);
                                           // listbox2.removeAt(listbox2.selectedIndex)
        }
    }
}
