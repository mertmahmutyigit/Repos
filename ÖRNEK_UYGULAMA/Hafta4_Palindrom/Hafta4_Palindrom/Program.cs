using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "ababa", "tallat", "misvak", "tren", "gnccng" };
            string r = "";

            for(int i = 0; i < dizi.Length; i++)
            { r ="";
                for (int j=dizi[i].Length-1; j >= 0; j--)
                {
                    r += dizi[i][j];
                }
                   
                if (dizi[i]==r)  Console.WriteLine(r + " palindrome"); 
                    else Console.WriteLine( r + " kelimesi palindrome değil"); 
            }
            Array.Resize(ref dizi, 6);//dizinin boyutunu arttırma 
            dizi[5] = "araban";       // diziye yeni eleman ekleme
            foreach(string i in dizi)
            Console.Write(i +" ");
            Console.ReadKey();
        }
    }
}
