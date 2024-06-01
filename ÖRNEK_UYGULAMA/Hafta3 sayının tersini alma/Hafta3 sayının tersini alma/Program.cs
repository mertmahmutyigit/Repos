using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_sayının_tersini_alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı; int rakam;
            Console.WriteLine("bir sayı gir");
            sayı = Convert.ToInt32(Console.ReadLine());

            while (sayı > 0)
            { rakam = sayı % 10;
                Console.Write(rakam);
                sayı /= 10;
            }
            Console.ReadKey();
        
        }
    }
}
