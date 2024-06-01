using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_metotlar_set_get_örnek
{
    public class ürün
    {  
        public string ürünkodu;
         public int ürünmiktarı;
         static string ürünbirimcinsi;
         static int ürünbirimfiyatı;
        static int toplammiktarı;

        public ürün(string ürünkodu, int ürünmiktarı, string ürünbirimcinsi, int ürünbirimfiyatı)
        {
            this.ürünkodu = ürünkodu;
            this.ürünmiktarı = ürünmiktarı;
            ürünbirimcinsi = ürünbirimcinsi;
            ürünbirimfiyatı = ürünbirimfiyatı;
        }
        public ürün(string ürünkodu, int ürünmiktarı) {
            this.ürünkodu = ürünkodu;
            this.ürünmiktarı = ürünmiktarı;
        }
        static ürün() { // parametresiz olmalıdır
            ürünbirimcinsi = "kg";
            ürünbirimfiyatı = 50;
        }
        public static void hesap() {
            toplammiktarı = ürünbirimfiyatı * 10;
            Console.WriteLine(toplammiktarı);
        }
        public void göster()
        {
            Console.WriteLine(" ürünkodu = " + ürünkodu);
            Console.WriteLine(" üürünmiktarı = " + ürünmiktarı);
            Console.WriteLine(" ürünkodu = " + ürünbirimcinsi);
            Console.WriteLine(" ürünkodu = " + ürünbirimfiyatı);


        }

    }
}
        











