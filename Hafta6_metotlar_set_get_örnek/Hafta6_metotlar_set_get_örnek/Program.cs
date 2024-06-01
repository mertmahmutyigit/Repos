using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_metotlar_set_get_örnek
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            ürün u = new ürün("kg",57398);
            u.göster();
            ürün u1 = new ürün("hf",678);
            u.göster();
            ürün.hesap();
 

            Console.WriteLine("-----------------------------------------------------------");
           set_get_metot s=new set_get_metot();
            s.setdeğeri(89);
            Console.WriteLine(s.getdeğeri());
           


            Console.WriteLine("-----------------------------------------------------------");
            set_get_property p=new set_get_property();
            p.isimdeğiş = "fadime";
            p.bilgigöster();
            
            Console.ReadKey();
        }
    }
}
