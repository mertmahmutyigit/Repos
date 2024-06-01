using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_İndeksleyici
{

    public class indek
    {
        public static string[] dizi = { "ali ", "veli", "yasemin" };

        public int this[string aranan]
        {
            get
            {    for(int i = 0; i < uzunluk; i++)
                {
                    if (aranan.Equals(dizi[i])) { return i; break; }
                   
                        
                }
                return -1;



            }
            
        }
        public string this[int indeks]
        {
            get
            {
                if (indeks < 0 || indeks > dizi.Length) return null;
                else return dizi[indeks];
            }
            set
            {

                if (!(indeks < 0 || indeks > dizi.Length))
                    dizi[indeks] = value;
            }


        }
        public int uzunluk
        {
            get { return dizi.Length; }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            indek i = new indek();
            Console.WriteLine(i[0]);
            i[0] = "kazım";
            Console.WriteLine(i[0]);
            
            if (i["veli"] >= 0) Console.WriteLine("aranan kelime var" + " " + i["veli"]);
       Console.ReadKey(); }
    }
}

