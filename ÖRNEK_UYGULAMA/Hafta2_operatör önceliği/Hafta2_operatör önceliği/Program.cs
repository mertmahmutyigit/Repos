using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_operatör_önceliği
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i; int sonuç;
            Console.WriteLine("iki sayı giriniz");
            i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            sonuç = i + -j;
            Console.WriteLine(sonuç);
            Console.Readkey();

        }
    }
}
