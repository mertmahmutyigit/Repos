using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_sayıların_asallığı
{
    internal class Program
    {
        static void Main(string[] args)
        { int sayaç = 0;
            Console.WriteLine("lütfen sayıyı giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; i < sayı; i++)
            {
                sayaç = 0;
                for (int j = 2; j < i; j++) {

                    if (i % j == 0) { sayaç++; }
                }
                if (sayaç == 0) { Console.WriteLine(i); }


            }
            Console.ReadKey();
        }
    }
}
