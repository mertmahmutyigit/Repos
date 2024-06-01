using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_örnek1_kutu_uygulaması
{
    class kutu
    {
        public double lenght;
        public double breadth;
        public double height;



    }
    // nese oluşturulup sınıflae içerisinde çağğırma işlemi yapıldı
   

    internal class Program
    { 
        static void Main(string[] args)
        {
            kutu kutu1 = new kutu();
            kutu kutu2 = new kutu();
            kutu kutu3 = new kutu();
            double value = 0.0;
            kutu1.height = 10;
            kutu1.lenght = 6.0;
            kutu1.breadth = 7.0;

            kutu2.breadth = 7.0;
            kutu2.lenght = 6.0;
            kutu2.height = 10;

            value = kutu1.height * kutu1.lenght * kutu1.breadth;
            Console.WriteLine("Valume of kutu1 = {0} ", value);
            value = kutu2.breadth * kutu2.height * kutu2.lenght;
            Console.WriteLine("value of kutu2 = {0}", value);
            Console.ReadKey();
        }
    }
}
