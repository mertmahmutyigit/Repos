using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FİNAL_2_Yıkıcı_metot
{ 

   public class uyg
    {
        ~ uyg() { Console.WriteLine("yıkıcı metot çalıştı yıkıyor "); }
        public static void konuş() { Console.WriteLine("static konuş metodu"); }
        static uyg() { Console.WriteLine("static yapıcı"); }
        public uyg() { Console.WriteLine("normal kurucu metot"); }
       


    }
    internal class Program
    { 
        static void Main(string[] args)
        {
            uyg u = new uyg();
            uyg u2 = new uyg();
            
         Console.ReadKey();
        }
    }
}
