using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_if_deyimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s;
            int a, b, c;
            Console.WriteLine("1.sayıyı giriniz : ? ");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);
            Console.WriteLine("2.sayıyı giriniz : ? ");
            s = Console.ReadLine();
            b = Convert.ToInt32(s);
            Console.WriteLine("3. sayıyı giriniz : ? " );
            s = Console.ReadLine();
            c = Convert.ToInt32(s);
            if (a >= b && a >= c) Console.WriteLine("en büyük =" + a);
            else if (b >= c) Console.WriteLine("en büyük : " + b);
            else Console.WriteLine("en büyük c = " + c);
            Console.ReadLine();
        }
    }
}
