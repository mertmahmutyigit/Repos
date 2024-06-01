using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4_Metot_faktöriyel
{
    internal class Program
    {
        static int fak(int sayı) {
            int sonuç = 1;
        
        for(int i = sayı; i > 0; i--)
            {
                sonuç *= i; 
            }
            return sonuç;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("faktöriyelini almak istediğiniz sayıyı giriniz = ");
            int sayı=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("işlemin sonucu = " + fak(sayı));
          Console.ReadKey();
        }
    }
}
