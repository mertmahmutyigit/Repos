using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Sayı_tahmini
{
    internal class Program
    { // 1 - 20 arasında sayı  üretsin ve bulunsun
        static void Main(string[] args)
        {
            Random r = new Random();
            int tahmin = r.Next(1, 20);
            int sayı;

            do
            {
                Console.WriteLine("bir sayı giriniz = ");
                sayı = Convert.ToInt32(Console.ReadLine());
                if (sayı < tahmin) Console.WriteLine("DAHA BÜYÜK SAYI GİRİNZ ");
                else if (sayı > tahmin) Console.WriteLine("daha küçük sayı giriniz");
                else Console.WriteLine("tebrikler doğru asyı " + sayı);
            }
            while (sayı != tahmin);


            Console.ReadKey();
        }
    }
}
