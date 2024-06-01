using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// çift sayıları alır
// kullanıcı tarafından bir sayılı alıncak sayı asal mıdır kontrol eder
// kullanıcıdan bir sayı gir bu sayıyı ters çevir
// girilen sayının basamak sayısını bulan program
// basamak değerlerinin toplamı yapan program
// kullanıcı tarafında girilen stringin tersini yazdıran program
namespace hafta1_örnek


{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.Write("sayı gir"); // kullanıcıya yazdırıyoruz
              int sayı = Convert.ToInt32(Console.ReadLine());
              for(int i = 0; i < sayı; i++)
              {
                  if (i % 2 == 1) {

                      Console.WriteLine(i);//line alt satıra geçer

                  }



              }Console.ReadKey();

            //-------------------//*/
            //
            Console.WriteLine("sayı gir");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            for(int i=2;i<sayı;i++)
            { 
                for (int j = 0; j < i; j++) {

                    if (i % j == 0) { sayac++; } }

                if (sayac == 0) { Console.WriteLine(i); }  



                        } 
            Console.ReadKey();// konsolu ekranda tutma
           
            





        }
    }
}
