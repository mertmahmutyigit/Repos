using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FİNAL_9_ABSTRACT_1
{   
    public abstract class d
    {
        public d() { }
        public void metot() { }
        public virtual void metot2() { }
       // public d(int d) { }

        public abstract void mett(int y);
        public abstract int y();
    }
    public class fe:d
    {
        public void metoto() { }
        public void metoto2() { }   
       public fe(int y) { }
        public override void mett(int y) { }
        public void metot2()
        {
            base.metot2();
        }

         public override int y()
        {
            return 0;   
        }

     
    }




















    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
