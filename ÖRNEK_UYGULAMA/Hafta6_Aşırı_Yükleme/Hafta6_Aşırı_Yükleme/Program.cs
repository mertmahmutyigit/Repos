using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
// static olmalı , metotların isimlerinde operatör sözcüğü kullanılmalı
// tek yada iki parametre plmalı en falza
namespace Hafta6_Aşırı_Yükleme
{
    class karmaşıksayı
    {

        private double gerçek;
        private double sanal;

        public double g
        {
            get { return gerçek; }
            set { gerçek = value; }

        }
        private double s
        {
            get { return sanal; }
            set { sanal = value; }
        }
        public karmaşıksayı(double gerçek, double sanal) {
            this.sanal = sanal;
            this.gerçek = gerçek;
        }
        public karmaşıksayı() { sanal = 0; gerçek = 0; }
        public karmaşıksayı(karmaşıksayı k) {
            sanal = k.sanal;
            gerçek = k.gerçek;

        }
        public void yaz() {
            if (sanal > 0) { Console.WriteLine("gerçek + " + " + sanal"); }
          else
                Console.WriteLine(gerçek + " - " + (-sanal));
        }
        public static karmaşıksayı operator +(karmaşıksayı a, karmaşıksayı b){
            double gt = a.gerçek + b.gerçek;
            double st = a.sanal + b.sanal;
            return new karmaşıksayı(gt, st);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         karmaşıksayı k1= new karmaşıksayı(4,40);
            k1.yaz();
            karmaşıksayı k2 = new karmaşıksayı(5,60);
            k2.yaz();
            karmaşıksayı k3 = k1 + k2;

            Console.ReadKey();
        
        }
    }
}
