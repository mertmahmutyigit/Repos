using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARABA_Galerisi_Hafta5
{
    public class Araba
    {
        public string marka;
        public short model;
        public string renk;
       public Araba(string marka,short model,string renk) {
            this.marka = marka;
            this.model = model; 
            this.renk = renk;   
        
        }
    }
}
