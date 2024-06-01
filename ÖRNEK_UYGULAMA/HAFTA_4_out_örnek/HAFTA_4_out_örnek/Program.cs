using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAFTA_4_out_örnek
{      // out kelimesi  meinde değer almaz metoda gider değer,ni alır gelir 
    internal class Program
    {
        static void degertipi(out int x) {
            x = 111;
        }
        static void Main(string[] args)
        {
            int x;
            degertipi(out x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
