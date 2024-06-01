using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_aritmetik_operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5; int b = 10; int c = 20;
            int d = 50; float f = 3.4f;
            a++;++b; c--;
            --d; f++;
            Console.WriteLine("{0}\n {1}\n {2}\n {3} \n {4}\n", a, b, c, d, f);
            Console.WriteLine("a+c={0}", a + c);
            Console.ReadKey();

        }
    }
}
