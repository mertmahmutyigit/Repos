using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Nesne_Uyg4
{
   class topla {
        int x;int y;

     public topla() { x = 6; y = 8; }   
    public int işlem() { 
            return x+y; }
    public void yaz() {
            Console.WriteLine("x =" + x);
            Console.WriteLine("y = " + y);

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            topla k = new topla();
            k.yaz();
            Console.ReadKey();
            k.işlem(k.x, k.y);
        }
    }
}
