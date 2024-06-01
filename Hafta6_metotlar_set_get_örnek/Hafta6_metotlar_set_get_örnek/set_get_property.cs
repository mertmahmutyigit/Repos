using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_metotlar_set_get_örnek
{
    internal class set_get_property
    {

        private string isim = "alizade";

        public string isimdeğiş
        {
            set { isim = value; }
            get { return  isim; }
        }
        public void bilgigöster()
        {
            Console.WriteLine(isim);

        }
    }
}
