using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARABA_Galerisi_Hafta5
{
   public class Galeri
    {
        private List<Araba> arabalar;
    public Galeri()
        {
         arabalar = new List<Araba>();   }
         
        public void Arabaekle(Araba a)
        {
            arabalar.Add(a);
        }
        public void arabasat(Araba a)
        {
            if(arabalar.Contains(a)) arabalar.Remove(a);

        }
        public string[] arabalistele()
        {
            string[] s= new string[arabalar.Count];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = arabalar[i].marka+" "+ arabalar[i].model +" "+arabalar[i].renk;
            }
            return s;
        }
    }
}
