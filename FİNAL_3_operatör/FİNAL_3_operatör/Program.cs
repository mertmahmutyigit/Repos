using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FİNAL_3_operatör
{


    public class operatr{
       public double sanal;
      public  double gerçek;
    public operatr() {

            sanal = 4;
            gerçek = 5;
        
        }
    public operatr(double sanal,double gerçek) { 
        
        this.sanal = sanal;
            this.gerçek = gerçek;
        }
        public static operatr operator +(operatr x,operatr y)
        {
            double snl = x.sanal + y.sanal;
            double grk = y.gerçek + y.gerçek;
            return new operatr(snl,grk);
        }
        }
    internal class Program
    {

        static void Main(string[] args)
        {
            operatr o1 = new operatr(4,8);
            operatr o2=new operatr(4,1);
            operatr o3 = o1 + o2;
            Console.WriteLine(o3.sanal+ " "+o3.gerçek);
            Console.ReadKey();
        }
    }
}
