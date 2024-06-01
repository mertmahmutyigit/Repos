using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_8_ÇOk_biçimlilik_örnek1
{
    public class persone
    {
        public int asgari = 7000;
        public int promosyon = 500;
        public string isim;
        protected decimal maas;// sadece alt sınıflarda erişim var eğer mainde erşmek istiyorsan get oluştur


        public decimal Maas
        {
            get { return maas; }
        }

        public persone(string isim)
        {
            this.isim = isim;
        }

        public virtual void Maashesapla()
        {
            maas = asgari + promosyon;

        }
    }

    public class çalışan : persone
    {
        public çalışan(string isim) : base(isim) { }
        public override void Maashesapla()
        {
            base.Maashesapla();
            maas = maas + 1.5M;
        }

    }
    public class mudur : persone
    {
        public mudur(string isim) : base(isim) { }
        public override void Maashesapla()
        {
            base.Maashesapla();
            maas = maas + 4M;
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            persone p = new persone("keyfi");
           
          mudur m=new mudur("ali müdürü");
            m.Maashesapla();
            Console.WriteLine(m.Maas);
            Console.ReadKey();
        }
    }
}
