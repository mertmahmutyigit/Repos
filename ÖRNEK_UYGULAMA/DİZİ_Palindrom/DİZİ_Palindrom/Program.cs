using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DİZİ_Palindrom
{
    internal class Program
    {
       

        static void Main(string[] args)
        { 
            string[] dizi = new string[] { "bilgisayar", "klavye", "sos", "abbba","baba" };
            string r = "";
            for (int i = 0; i < dizi.Length; i++)
            {
                r = "";
                for (int j = dizi[i].Length-1;j>=0 ; j--) {
                r+= dizi[i][j]; }
                if (r == dizi[i]) Console.WriteLine(dizi[i] + "  palindrom");
                else Console.WriteLine(dizi[i] + "   palindrom değil"); 
            }
            Console.ReadKey();

        }
    }
}
