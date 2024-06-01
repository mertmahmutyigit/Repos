using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FİNAL_5_Enum
{enum renk : byte {siyah,beyaz,sarı,kırmızı}
    public class örnek {

        public static void gelinlikler()
        {


            for (renk i = renk.siyah; i <= renk.kırmızı; i++)
            {
                Console.WriteLine("gelinlik renkleri sırasıyla = "
                + (int)i + " " + i);
            }
        }
           
       public örnek(int x)
        {     renk b = renk.kırmızı;
                int a = (int)b;
            if (x <=a ) { Console.WriteLine("gelinliğin rengi = " + (renk)x); }
        }
           
          
     }
    
    internal class Program
    { 


        static void Main(string[] args)
        {   örnek.gelinlikler();
            Console.WriteLine("bir gelinlik numarası seçiniz");
            int x=Convert.ToInt32(Console.ReadLine());
            örnek ö = new örnek(x);
            renk r = renk.siyah;
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
