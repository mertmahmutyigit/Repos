using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Operator_aşırı_yükleme__
{
    class karmaşıksayı {
        private int sanal = 90;
        private int gerçek = 50;
        public int Sanal
        {
            set { sanal = value; }
            get { return sanal; }
        }
        public int Ger
        {
            set { gerçek = value; }
            get { return gerçek; }
        }
       public karmaşıksayı(int sanal, int gerçek)
        {
            this.sanal = sanal;
            this.gerçek = gerçek;
        }
        
        public void yazdır()
        {
            Console.WriteLine(sanal + " " + gerçek);}
        public static karmaşıksayı operator +(karmaşıksayı a,karmaşıksayı b)
        {
            int sanall = a.sanal + b.sanal;
            int gerçek = a.gerçek + b.gerçek;
            return new karmaşıksayı(sanall, gerçek);
        }
        public static karmaşıksayı operator *(karmaşıksayı a,karmaşıksayı b)
        {
            int sanal=a.sanal * b.sanal;
            int gerçek = b.gerçek * b.gerçek;
            int toplam = sanal + gerçek;
            int çıkar = sanal - gerçek;
            return new karmaşıksayı(toplam, çıkar);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            karmaşıksayı k1 = new karmaşıksayı(56, 76);
         k1.Sanal = 67;  
         
            karmaşıksayı k2 = new karmaşıksayı(87,54);k1.yazdır();
            karmaşıksayı k3 = k1 + k2;
            k3.yazdır();
            karmaşıksayı k4=k1*k2;
            k4.yazdır();
            Console.ReadLine();
        }
    }
}
