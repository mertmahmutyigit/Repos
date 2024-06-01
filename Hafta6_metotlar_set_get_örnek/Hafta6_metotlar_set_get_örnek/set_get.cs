using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_metotlar_set_get_örnek
{
    internal class set_get_metot
    { // metot ile set get yapma
        private int no = 890456;
        public void setdeğeri(int eleman)
        {
            this.no = eleman;

        }
        public int getdeğeri()
        {

            return this.no;
        }
    }
}
