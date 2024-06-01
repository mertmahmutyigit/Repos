using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7_enum_örnek2_aylar_mevsimler
{ enum aylar : byte { ocak=1 ,şubat,mart,nisan,mayıs,haziran,temmuz,ağustos,eylül,ekim,kasım,aralık};
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı=Convert.ToInt32(Console.ReadLine());
            aylar a = (aylar)sayı;
            switch(sayı)
            {   
                case 12:
                case 1:
                case 2:Console.WriteLine("kış mevsimi " + a); break;
                    
                case 3:
                case 4:
                case 5:Console.WriteLine("ilk bahar"); break;
                
                case 6:
                case 7:
                case 8:Console.WriteLine("yaz"); break;

                case 9:
                case 10:
                case 11:Console.WriteLine("son bahar");
                    break; ;
                   


            }Console.ReadKey();
        }
    }
}
