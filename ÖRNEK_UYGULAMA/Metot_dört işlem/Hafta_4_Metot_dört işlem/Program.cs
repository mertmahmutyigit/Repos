using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4_Metot_dört_işlem
{
    internal class Program
    {
        int dortislem(int sayı1, int sayı2, char c) {
            int sonuç;
            if (c == '+') sonuç = sayı1 + sayı2;
            else if (c == '-') sonuç = sayı1 - sayı2;
            else if (c == '*') sonuç = sayı1 * sayı2;
            else if (c == '/') sonuç = sayı1 / sayı2;
            else sonuç=-1;
            return sonuç;
        
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Console.WriteLine("sayı 1 = ");
            int sayı1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı 2 = ");
            int sayı2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yapılacak işlem nedir =");
            char işlem=Convert.ToChar(Console.ReadLine());
            int sonuç = p.dortislem(sayı1, sayı2, işlem);
            Console.WriteLine("işlem  ==>  {0}  {1}  {2} =  {3}", sayı1, işlem, sayı2, sonuç);
            Console.ReadKey();
        }
    }
}
