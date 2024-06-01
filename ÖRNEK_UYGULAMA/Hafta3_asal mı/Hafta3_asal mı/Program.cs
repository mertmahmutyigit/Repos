using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_asal_mı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen  bir sayı giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            bool kontrol = true;
            int k = 2;
            while (kontrol) {

                if (sayı % k == 0) { kontrol = false; break; }
                k++;
                if (k == sayı) break;
            }
            if (kontrol) Console.WriteLine("sayı asaldır " + sayı);
            else
                Console.WriteLine("sayı asal değildir");
            Console.ReadKey(); }
    }
}
