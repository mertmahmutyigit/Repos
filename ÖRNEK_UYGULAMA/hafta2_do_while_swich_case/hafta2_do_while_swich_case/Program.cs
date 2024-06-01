using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2_do_while_swich_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seçim;

            do
            {
                Console.WriteLine("işlemler \n======");
                Console.WriteLine("1- toplama");
                Console.WriteLine("2- çıkarma");
                Console.WriteLine("3- çarpma");
                Console.WriteLine("4- bölme");
                Console.WriteLine("0- çıkış \n");
                Console.WriteLine("işleminizi seçin:");
                seçim = Convert.ToInt32(Console.ReadLine());
                switch (seçim)
                {
                    case 1: Console.WriteLine("toplama işlemi  seçildi."); break;
                    case 2: Console.WriteLine("çıkarma işlemi seçildi."); break;
                    case 3: Console.WriteLine("çarpma işlemi seçildi."); break;
                    case 4: Console.WriteLine("bölme işlemi seçildi. "); break;
                    case 0: Console.WriteLine("çıkış seçildi. "); break;
                    default: Console.WriteLine("yanlış seçim. "); break;




                }



            }

            while (seçim != 0);


            Console.ReadKey();
        }
    }
}
