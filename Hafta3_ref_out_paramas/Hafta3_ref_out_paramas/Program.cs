using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
// ref out params kullanımı 
namespace Hafta3_ref_out_paramas
{
    internal class Program
    {
       static int sayı = 0;
        static void degistir( out int sayı)
        {
            sayı = 10;

        }
        static void yaz(int sayı)
        {   
            
            Console.WriteLine(sayı);

        }
        static void metot(int x) { Console.WriteLine("tek parametreli metotlar  "+ x); }
        static void metot(int x,params int[] y) {
        Console.WriteLine("params metotdu çoktan parametreli metotlar  " + x +"  " + y[0]);
        }
        static void Main(string[] args)
         {
            /*  int say = 9;
              int sayı = 1;
              //degertipi(ref sayı);
              degiştir(sayı);
              degertipi( say);
              Console.WriteLine(say);
              metot(3);
              metot(4,5,8);
               */
            int sayı = 1;
            degistir(out sayı);
            Console.WriteLine(sayı);
            yaz(sayı);
            Console.ReadKey();
        }
    }
}
