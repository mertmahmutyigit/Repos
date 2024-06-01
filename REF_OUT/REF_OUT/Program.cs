using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REF_OUT
{
    internal class Program
    {
        static void arttır(out int s) {
            s = 12;
            s++;
        }
        static void Main(string[] args)
        {
            int sayı ;
            arttır(out sayı);
            Console.WriteLine(sayı);
            Console.ReadKey();
        }
    }
}
