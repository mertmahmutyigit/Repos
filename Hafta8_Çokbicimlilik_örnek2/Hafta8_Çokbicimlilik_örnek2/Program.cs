using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta8_Çokbicimlilik_örnek2
{
    public class ogrenci
    {
        public decimal birimdersücreti = 60;
        public string isim;
        public short kredisayısı;
        public decimal toplamdersücreti;
        public ogrenci(string isim,short kredisayısı) {this.isim = isim; this.kredisayısı = kredisayısı; } 
        public decimal toplamdersücret
        {
            get { return toplamdersücreti; } }
    public virtual void dersucretihesapla()
        {
            toplamdersücreti = birimdersücreti * kredisayısı;
        }
    
    }
    public class bursluogrenci:ogrenci
    {
        public short bursoranı;
        public decimal bursindirimi;
        public decimal burindirim
        {
            get { return bursindirimi; }
        }
        public bursluogrenci(string isim,short kredisayısı):base(isim,kredisayısı) { }
        public override void dersucretihesapla()
        {
            base.dersucretihesapla();
            bursindirimi = (toplamdersücreti + bursoranı) / 100;
            toplamdersücreti -= bursindirimi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci o = new ogrenci("ali", 10);
            o.dersucretihesapla();
            Console.WriteLine(o.toplamdersücreti);
            bursluogrenci bo = new bursluogrenci("ali", 10);
            bo.kredisayısı = 40;
            bo.bursoranı = 380;
            bo.dersucretihesapla();
            Console.WriteLine(bo.toplamdersücreti);
            Console.ReadKey();
        }
    }
}
