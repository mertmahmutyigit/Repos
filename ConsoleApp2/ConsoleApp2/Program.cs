using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{




    public abstract class a {
        public a() { }
        public abstract void f();

        public void c() { }

    }

    public class b : a {

        public b(){}
        public override void f()
        {
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
