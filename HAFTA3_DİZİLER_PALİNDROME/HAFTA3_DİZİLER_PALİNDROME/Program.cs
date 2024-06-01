using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAFTA3_DİZİLER_PALİNDROME
{
    internal class Program
    {

        int[,] dizi = new int[3,3];
        int[][] dizi2 = new int[3][];
        string[] dizi3 = { "merorem", "aaabaaa", "anna", "irem", "ada" };
        public void ekle2()
        {
            int k = 1;
            for(int i = 0; i < 3; i++)
                for (int j =i; j < 3; j++)
                {
                    dizi[i,j] = k; dizi[j,i] = k;
                    k++;

            }


        }
        public void ekle() {
            int sayı; 
            
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++) { 
               sayı=Convert.ToInt32(Console.ReadLine());
                    dizi[i,j] = sayı;

                }

        }
        public void yazdır1(int [,] dizi)
        {
            for (int i = 0; i < 3; i++)
            {   
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
        public void yazdır(Array arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        public void palindrome(string[] dizi)
        { string r ;
            for(int i = 0;i < dizi.Length; i++)
            {
                r = "";
                for(int j = dizi[i].Length-1; j >= 0; j--) {
                    r += dizi[i][j];
                }
                if (dizi[i] == r) { Console.WriteLine(r+"  palindrome"); }
               
            }
                
        }

        static void Main(string[] args)
        {
            Program p= new Program();   
           // p.ekle2();
            //p.yazdır1(p.dizi);
            p.palindrome(p.dizi3 );
            //p.yazdır(p.dizi);
            Console.ReadKey();
        }
    }
}
