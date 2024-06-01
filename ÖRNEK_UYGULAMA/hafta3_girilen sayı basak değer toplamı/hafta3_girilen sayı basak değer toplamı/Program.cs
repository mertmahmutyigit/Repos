using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta3_girilen_sayı_basak_değer_toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı giriniz");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int carpan = 1; int kalan = 0;
            bool kontrol = false; int mod = 0;
            while (!kontrol) {
                mod = sayı % (carpan * 10);
                kalan = mod / carpan;
                toplam += kalan;
                carpan *= 10;
                kontrol = (mod == sayı);
            }
            Console.WriteLine("basamak değeri toplamı " + toplam);
            Console.ReadKey();
        }
    }
}
