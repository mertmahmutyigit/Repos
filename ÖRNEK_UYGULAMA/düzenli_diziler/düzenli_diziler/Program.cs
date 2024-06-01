using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace düzenli_diziler
{
    // simetrik dizi yazdır
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[4, 4];
            Random r = new Random();
            int k = 1;
            for (int i =0;i<4;i++)
            {
                for (int j = i; j < 4; j++) {

                    dizi[i,j] = k;   dizi[j,i] = k;
                    k++;
                   
                    
                }
               
               

            }
            k = 1;
            foreach (int h in dizi) {
                if (k % 4 == 0) {
                    Console.Write(h);
                    Console.WriteLine();
                
                }
                else { 
                    Console.Write(h + " "); }
            
             k++;
            }
            Console.ReadKey();
        }
    }
}
