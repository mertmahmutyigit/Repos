using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_toplaortalama_out
{
    internal class Program
    {
        static int toplaort(int[] dizi, out double ort) {
            int top = 0;
            foreach (int d in dizi) 
                top += d;
                ort=(double) top/dizi.Length;
                
            
            return top;
           }

        static void Main(string[] args)
        {    double x;
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 14, 15, 16 };
           int t= toplaort(dizi, out x);
            Console.WriteLine("dizinin elemanlar toplamı : {0} , ortolaması : {1} ", t, x);
            Console.ReadKey(); }
    }
}
