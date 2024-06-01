using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_while_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n;
            Console.WriteLine("hangi sayıya kadar yazsın= ?");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n) {
                Console.WriteLine("i = " + i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
