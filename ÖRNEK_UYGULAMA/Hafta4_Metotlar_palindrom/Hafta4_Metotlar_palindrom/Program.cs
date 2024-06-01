using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Metotlar_palindrom
{
    internal class Program
    {
        int palindrommu(string[] kelimeler) {
            string r; int sayaç = 0;
        for (int i = 0; i < kelimeler.Length; i++)
            {
                r = "";
                for (int j = kelimeler[i].Length-1;j>=0 ; j--)
                {
                    r += kelimeler[i][j];
                }
                if (r == kelimeler[i]) sayaç++;
            }

            return sayaç;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            String[] dizi = new string[] { "bilgisayar", "klavye", "sos", "abbba", "lalal" };
            int say=p.palindrommu(dizi);
            Console.WriteLine(say+ "  tane palindrom var");
            Console.ReadKey();
        }
    }
}
