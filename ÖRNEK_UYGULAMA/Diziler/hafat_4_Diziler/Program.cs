using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafat_4_Diziler
{ // matris oluştur buna random ile değer ata
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[10,10];
            Random r=new Random();
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    dizi[i,j] = r.Next(1, 100);
                    Console.Write(dizi[i, j] + " ");
                    
                
                }
                Console.WriteLine();
                
            }
Console.ReadKey();




        }
    }
}
