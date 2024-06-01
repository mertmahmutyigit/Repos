using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("selam \t dünya");
             //Console.Write("selam"); diyede biliriz (/t bir boşluk bırakıyor )
             Console.ReadKey();
            */




            // ____________________________________________________________________________________
            /* int sayı;
             Console.Write("sayı gir = ");  // Line alt satıra geçme işlemi yapar 
             sayı = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("girilen sayı = " + sayı);
             Console.WriteLine("girilen sayı:{0}", sayı);// o virgülden sonraki ilk sayı 
             Console.ReadKey();
            */
            //______________________________________________________________________________________



            //______________________________________________________________________________________

            /*
            float sayı1 ,sayı2, top;
            Console.WriteLine("iki sayının toplamı ");
            Console.Write("1. sayı =");
            sayı1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("2.sayı=");
            sayı2 = Convert.ToSingle(Console.ReadLine());
            top = sayı1 + sayı2;
            Console.WriteLine("{0}+{1}={2}", sayı1, sayı2, top);
            Console.WriteLine(sayı1 + "+" + sayı2 + "=" + top);
            Console.ReadLine();
            */

            //______________________________________________________________________________________


            /*
            int bolum = 50, bolen = 8;
            int kalan = bolum % bolen;
            int sonuç = bolum/ bolen;
            Console.WriteLine("{0}/ {1}={2}",bolum, bolen, sonuç);
            Console.WriteLine("{0}mod {1}={2}", bolum, bolen, kalan);
            Console.ReadKey();

            */
            //________________________________________________________________________________

            /*
           string cumle;
           Console.Write("bir cümle gir =");
           cumle = Console.ReadLine(); // direkt stirn değer algılanır part etmeye gerek yok
           string[] kelimeler = cumle.Split(' ');
           for (int i = 0; i < kelimeler.Length; i++)
           {
               Console.WriteLine(kelimeler[i]);

           }
           Console.WriteLine("{0} cümlesi {1} kelimeden oluşur ", cumle, kelimeler.Length);
           Console.ReadKey();

       */


            //________________________________________________________________________________



            double taban, us;
            Console.WriteLine("taban gir");
            taban = Convert.ToDouble(Console.ReadLine());
            Console.Write("us gir");
            us = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" {0} ^{1}= {2}", taban, us, Math.Pow(taban,us));
            Console.ReadLine();


        
        }
    }
}
