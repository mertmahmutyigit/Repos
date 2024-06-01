using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Düzensiz_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] dizi = new int[3][];
            dizi[0] =new int[]{ 1,2};
            dizi[1] =new int[]{ 3,4,5,6,7};
            dizi[2]=new int[] { 8,9,0};
            for (int i = 0; i <dizi.GetLength(0); i++) {

                for (int j = 0; j < dizi[i].GetLength(0); j++) {
                    Console.WriteLine("dizi[{0}][{1}]={2}" ,i,j,dizi[i][j]);
                
                }
            
            }
            Console.ReadKey();


        }
    }
}
