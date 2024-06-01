using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FİNAL_10_ABSTARCT_ÖRNEK
{
       public  interface Icalıs {
         string b();
    
    }
    public abstract class calısan {
       
        
        public abstract int maashesapla();
         
    }

    public class isci :calısan, Icalıs
    {
        public override int maashesapla() { return 0; }
      public string b() { return "fds"; }

       
    }


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
