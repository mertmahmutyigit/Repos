using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_1_100_tek_çift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tek = 0;
            int çift = 0;
            for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) çift++;
                else
                    tek++;

            }
            Console.WriteLine("tek sayıların toplamı = {0}\nçift sayıların toplamı= {1}", tek, çift);
            Console.ReadKey();

        }
    }
}
