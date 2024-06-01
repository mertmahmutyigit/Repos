using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_7_enum_örnek1_yanaltrenk
{ 
    enum bicim : byte {yanına,altına};
    enum renkler: byte {sarı,truncu,mavi,kırmızı,lacivert,beyaz,siyah};
    internal class Program
    {
       public Program(Array dizi, bicim b)
        {
            if (b == bicim.yanına)
            {
                foreach (string s in dizi)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
               
                }
            if (b == bicim.altına)
                {
                    foreach (string s in dizi)
                    {
                        Console.WriteLine(s);
                    } }
        }
        static void Main(string[] args)
        {
            string[] isim =  { "irem yiğit","ada yiğit","mert mahmut yiğit" };
            
            Program p=new Program(isim,bicim.yanına);
            Program p2 = new Program(isim, bicim.altına);
            renkler r = renkler.sarı;
            int t=(int)renkler.sarı;
            Console.WriteLine("sayı gir");
            int sayı = Convert.ToInt32(Console.ReadLine());
            bicim b2 = (bicim)sayı;
            Console.WriteLine( b2);

            Console.WriteLine(r+" "+t);
           Console.ReadKey();

        }
    }
}
