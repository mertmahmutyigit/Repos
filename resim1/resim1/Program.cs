using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace resim1
{
  public interface A
    {
       void c();

    }
    class b : A
    {
         void A.c() { Console.WriteLine("selam"); }
    }
    public class Program
    {
    
        static void Main(string[] args)
        {
          b n= new b();
          
           n.A.c();
            Console.ReadKey();
        }
    }
}
