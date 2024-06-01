using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FİNAL_1_params
{
    public class p
    {
        public int top;
       public int topla(int x,params int[] y) {
            
            foreach (int i in y)
                top += i;
            top = x + top;
            return top;

        }
     
        public p() { }

        public p( ref int[] y)
        {
            foreach (int i in y)
                top += i;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] y = {4,6,5,3,2,1};
            //p d = new p();
            p d1 = new p(ref y);
            p d2 = new p();

            Console.WriteLine(d1.top);
            Console.WriteLine( d2.topla(10, 50, 48, 23, 4, 2, 9));
            
        Console.ReadKey();
        }
    }
}
