using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_7_Kalıtım_2_personel
{
    public class personel
    {
        private const decimal asgari = 8000;
        private const decimal ek = 750;
        public string isim;
        protected decimal maas;
        public decimal mas
        {
            get { return maas; }
            set { maas = value; }
        }
        public personel(string isim) { this.isim = isim; }
        public virtual void maashesapla() {
            maas = asgari + ek;
        }

    }


    public class calısan : personel
    {
        public calısan(string isim):base(isim) {}

        public override void maashesapla()
        {
            base.maashesapla();
            maas = maas * 1.5m;
        }


    }        
    public class mudur : personel
    {
        public mudur(string isim):base(isim) { }
        public override void maashesapla()
        {
            base.maashesapla();
            maas = maas * 2m;
        }

    }    
        
        
        
        
        internal class Program
    {
        static void Main(string[] args)
        {
            calısan csn = new calısan("irem");
            csn.maashesapla();
            Console.WriteLine(csn.isim + "  =" + csn.mas);
            mudur mdr = new mudur("mert");
            mdr.maashesapla();
            Console.WriteLine(mdr.isim+" aldığı maaş ="+mdr.mas);
            Console.ReadKey();
        }
    }
}
