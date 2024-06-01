using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta8_çokbiçimlilik
{ // kalıtım bir ana sınıfın  çocuk sınıflarla birleşmesi
  // çok biçimlilik kalıtım alındıktan sonra bir metodun diğer sınıflarda kullanılması ezilerek
    
    public class ata { public int a; }
public class ana
    {
        
        public ana() { Console.WriteLine("ana kurucu paramatresiz"); }
        public ana(int name) { Console.WriteLine(name); }
    public virtual int dön(int d) { return d; }
    public virtual int yaşa(int ya) { return ya; }  
    }


  public class alt:ana { 
      public alt(int x):base(x) { Console.WriteLine("alt paramatereli "  ); }

  public override int dön(int y) { return y; }
        public override int yaşa(int ya)
        {
            return ya;  
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        alt a = new alt(5);
        Console.ReadKey();
        }
    }
}
