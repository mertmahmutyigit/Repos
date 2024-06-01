using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FİNAL_6_KALITIM_1
{
    public class ana
    {
        public int s;
      // public ana() { Console.WriteLine("parametresiz"); }
       public ana(int x) { Console.WriteLine("tek parametreli"); }
        public void top() { Console.WriteLine("fgjk"); }
    }
   public class baba:ana {
       //public baba() { }
    public baba(int x,int y):base(y){ }
    }

   public class yavru : baba
    {   
       
        public yavru(int x,int y):base(x,y) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            yavru y=new yavru(5,6);
            y.top();
            //baba b = new baba(5,4);
            Console.ReadKey();
        }
    }
}
