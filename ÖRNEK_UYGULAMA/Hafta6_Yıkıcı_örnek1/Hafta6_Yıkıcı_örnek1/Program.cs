using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Hafta6_Yıkıcı_örnek1
{
    public class Ogrenci
    {
        public Ogrenci()
        {
            Console.WriteLine("Yapıcı metot çalıştı.");
        }
        static Ogrenci() { Console.WriteLine("static kurucu isimli meto"); }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Numara { get; set; }
        public double Ortalama { get; set; }

        ~Ogrenci()
        {
            Console.WriteLine("Yıkıcı metot çalıştı.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uygulama başladı.");
            Ogrenci yeniOgrenci = new Ogrenci();
            Console.WriteLine("Öğrenci nesnesi oluştu.");
            
            Console.WriteLine("Uygulama bitti.");
            Console.ReadKey();
        }
    }
}
