using Hafta6_Nesneler_labdersi_örnek2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// KPSÜLLEME İLE PRİVATE DEĞERE ATAMA YAPMA 
// POPERİSTES İLE PRİVATE DEĞERE ATAMA YAPMA
namespace Hafta6_Nesneler_labdersi_örnek2
{
    public class ögrenci
    {
        public string ad;
        private string soyad;

        public void Setsoyad(string soyad) { this.soyad = soyad; }
        public string Getsoyad() { return soyad; }

}
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        ögrenci ö1 = new ögrenci();
        ö1.Setsoyad("kamil");
        
        Console.WriteLine(ö1.Getsoyad());
        Console.ReadLine();
    }
    }

