using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HAFTA5__ARABA_GALERİSİ
{
    public class Gleri
    {
        private List<araba> arabalar;
       public Gleri() { arabalar = new List<araba>(); }

        public void arabaekle(araba a) { arabalar.Add(a); } 
        
        public void arabasat(araba a)
            {

                if(arabalar.Contains(a)) // a yı içeriyorsa contains 
             arabalar.Remove(a);// a yı si
                                }

        public string[] arabalistele() {
            string[] s = new string[arabalar.Count];// count boyutu eleman sayısı
          for (int i = 0; i <s.Length; i++)
            {
                s[i] = arabalar[i].marka + " " + arabalar[i].model + " " + arabalar[i].renk;
            }
            return s; }
    }
}
