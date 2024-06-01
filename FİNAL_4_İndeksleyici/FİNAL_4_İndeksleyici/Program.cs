using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FİNAL_4_İndeksleyici
{
    public class indeksle
    {
        string[] isim = { "mert", "mahmut", "yiğit", "araban spor", "gaziantep" };
        public string this[int indeks]
        {

            get { return isim[indeks]; }
            set { isim[indeks] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            indeksle i=new indeksle();
            Console.WriteLine(i[0]);
            Console.ReadKey();

        }
    }
}
