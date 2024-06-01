using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Thisanahtarı_Örnek2
{
    class Program  // bir program static ise içinde statik olmayan ne metot ne de değişken tanımlanır
    {
        int topla; // golobal alandakş değişken 
                         
        public void sayıtopla(int topla)
        {
       this.topla+=topla;
        }
         public void sayıyıekranayaz() {
            Console.WriteLine("toplam = " + topla);

        
        }




        static void Main(string[] args)
        {Program p=new Program();
         p.sayıtopla(20);
         p.sayıtopla(30);

            p.sayıyıekranayaz();
            Console.ReadKey();
           }
    }
}
