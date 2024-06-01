using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizilerde_Metotlar_SORT_BİNARSERACH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizi =  { "zeynep", "fatma", "ali", "yılmaz", "gökhan", "osman", "feride" };
            //Console.WriteLine("Dizinin elemanları : ");
            //foreach (string d in dizi)             Console.Write(d+" ");


            Array.Sort(dizi);//diziyi küçükten büyüğe sıralama
            Console.WriteLine();
             Console.WriteLine("Sıralanmış dizi : ");
             foreach (string l in dizi) Console.Write(l+ "  ");
             Console.WriteLine();
            Console.WriteLine("Aranacak ismi giriniz = ");
            string s=Console.ReadLine();
            int indeks = Array.BinarySearch(dizi, s);
            if (indeks < 0) Console.WriteLine("aranan isim bulunamadı ");
            else Console.WriteLine("  aranan isim dizinin {0}. elemanında bulundu  ", indeks);


            Console.ReadKey();

        }


       
    }
}
