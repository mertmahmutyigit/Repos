using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;   int a;
            Console.WriteLine("kaçıncı sınıftasınız : ");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);
            switch (a)
            {
                case (0):
                case (1): Console.WriteLine("daha yenisiniz"); break;
                case (2): Console.WriteLine("mirasçısınız"); break;
                case (3): Console.WriteLine("ev sahibisiniz"); break;
                case (4): Console.WriteLine("misafirsiniz "); break;
                default: Console.WriteLine("siz okulu uzatmışsınız"); goto case 1;






            }

            Console.ReadKey();



        }
    }
}
