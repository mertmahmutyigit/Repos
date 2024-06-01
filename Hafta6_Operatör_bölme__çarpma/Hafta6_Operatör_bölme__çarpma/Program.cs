using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6_Operatör_bölme__çarpma
{
    class op
    {
        private int sanal;
        private int gerçek;
        public int setgetsanal
        {
            get { return sanal; } set {  sanal = value; }


        }
        public int setgetgerçek
        {

            get { return gerçek; }
            set { gerçek = value; }
        }
        public op(int sayı1,int sayı2)
        {
            sanal = sayı1;
            gerçek = sayı2;

        }
        public void yaz() { Console.WriteLine(sanal + " " + gerçek); }
       
        public op(op t)
        {
            sanal=t.sanal;
            gerçek = t.gerçek;

        }
        public static op operator /(op a,op b)
        {
            int gerçek = a.gerçek / b.gerçek;
            int sanal = a.sanal / b.sanal;
            return new op(gerçek, sanal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            op o = new op(9,7);
          
            o.setgetsanal = 1;
            o.setgetgerçek = 1; 
            o.yaz();
            op o1=new op(10,11);
            

            Console.ReadKey();
        }
    }
}
