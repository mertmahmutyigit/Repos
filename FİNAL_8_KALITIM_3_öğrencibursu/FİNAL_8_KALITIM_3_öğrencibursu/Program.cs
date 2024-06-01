using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FİNAL_8_KALITIM_3_öğrencibursu
{
    public class ögrenci
    {    
        public const int birimdersücreti = 60;
        public string isim;
        public short kredisayısı;
        public decimal toplamdersücreti;

        public decimal toplamdersücret
        {
            get { return toplamdersücreti; }
    
        }

        public short kredisay
        {
            set { kredisayısı = value; }
        }
       public ögrenci(string isim) { this.isim = isim; }

        public virtual void Dersücretihesabı() {
            toplamdersücreti = kredisayısı * birimdersücreti;
        
        } }

    public class bursluögrenci : ögrenci
    {
        public short bursoranı;
        public decimal bursindirimi;
        public bursluögrenci(string isim,short bursoranı):base(isim) { this.bursoranı = bursoranı; }
       
       
        public override void Dersücretihesabı()
        {
            base.Dersücretihesabı();
            toplamdersücreti -= bursoranı;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ögrenci ögr = new ögrenci("mert");
            ögr.kredisay = 40;
            ögr.Dersücretihesabı();
            Console.WriteLine(ögr.toplamdersücret);
            

            bursluögrenci bögr=new bursluögrenci("mertttt",1000);
            bögr.kredisay = 50;
            bögr.Dersücretihesabı();
            Console.WriteLine(bögr.toplamdersücret);
       Console.ReadKey(); 
        
        
        }
    }
}
