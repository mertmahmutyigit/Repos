using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_for_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı giriniz : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for(int i = 0; i <= n; i++)
            {

                toplam = toplam + i;

            }

            Console.WriteLine("1\'den {0}'e kadar olan sayıların toplamı {1}  dir. ", n, toplam);
            Console.ReadKey(); }
        
    }
}
