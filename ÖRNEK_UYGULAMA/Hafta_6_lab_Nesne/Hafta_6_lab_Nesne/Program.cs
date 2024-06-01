using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// static metotların kulanımı ve önemi 
// kurucu metotları tanımlama çağırma düzenleme 
// static kavramının önemini anlatan soru 
namespace Hafta_6_lab_Nesne
{
    public class ürün {
        public string ürünkodu;
        public string ürünbirimcinsi;
        public int ürünmiktarı;
        public int ürünbirimfiyatı;
        public static int a;

        public ürün(string ürünkodu, string ürünbirimcinsi, int ürünmiktarı, int ürünbirimfiyatı)
        {
            this.ürünkodu = ürünkodu;
            this.ürünbirimcinsi = ürünbirimcinsi;
            this.ürünmiktarı = ürünmiktarı;
            this.ürünbirimfiyatı = ürünbirimfiyatı;
        }
        static ürün() {
            Console.WriteLine("static metot çağırıldı a değeri = " + a);
        }
        public void bilgigöster() {

            Console.WriteLine("ürün  kodu = " + ürünkodu);
            Console.WriteLine("ürün  birimcinsi = " + ürünbirimcinsi);
            Console.WriteLine("ürün  miktarı= " + ürünmiktarı);
            Console.WriteLine("ürün  birim fiyatı = " + ürünbirimfiyatı);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ürün u1 = new ürün("koton", "pamuk", 50, 20);
            u1.bilgigöster();
            ürün u2 = new ürün("lcw","yün",60,13);
            u2.bilgigöster();
           int b= ürün.a;
            Console.WriteLine(b);Console.ReadKey();
        }
    }
}
