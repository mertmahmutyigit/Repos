using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_düzenli_diziler
{  // dizi oluştur değer ata sırala yanına yazdır satırları toplam satırları sırala 
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] dizi = new int[10, 10];
            int[] satırtop = new int[10];

            Random rnd = new Random();
            int top = 0;
            for(int i = 0; i < dizi.GetLength(0); i++)
            {
                for(int j = 0; j < dizi.GetLength(1); j++)
                {
                    dizi[i, j] = rnd.Next(1,100);
                    Console.Write(dizi[i, j] +" ");
                    top += dizi[i, j];
                }
                Console.Write("dizinin toplamı " + top);
                Console.WriteLine();
                satırtop[i] = top;

            }
            foreach(int s in satırtop)
            {
                Console.Write(s + " "); 

            }
            Console.ReadKey();
        }
    }
}
