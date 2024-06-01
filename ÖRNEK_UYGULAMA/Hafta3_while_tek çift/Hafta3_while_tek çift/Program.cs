using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_while_tek_çift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir sayı giriniz ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < sayı) {

                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey();
            
        }
    }
}
