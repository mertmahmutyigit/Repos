using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// DİZİYE ELMAN ATAMA VE YAZDIRMA
namespace Hafta4_tekboyutlu_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            Random r = new Random();
        for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(1,100);  }
            foreach (int j in dizi) Console.WriteLine(j);
            Console.ReadLine();

        }
    }
}
