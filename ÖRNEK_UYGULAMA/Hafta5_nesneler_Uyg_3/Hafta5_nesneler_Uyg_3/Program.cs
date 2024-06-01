using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_nesneler_Uyg_3
{
   public class isci
    {
        private int kimlikno;
        public int Kimlikno { 
        
        get { return kimlikno; } 
            set {  kimlikno = value; }
        }

     public string karşılamamesajı() {
        return "hoşgeldinşiz "+kimlikno +" numarlı öğrencimiz ";
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            isci i = new isci();
            i.Kimlikno=32764362;
            
            Console.WriteLine(i.karşılamamesajı());
            Console.ReadKey();
        }
    }
}
