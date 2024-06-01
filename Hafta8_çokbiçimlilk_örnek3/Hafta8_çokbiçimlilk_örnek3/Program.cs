using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hafta8_çokbiçimlilk_örnek3
{  public enum KitapDurumEnum { Yayınlandı,Reddedildi,İncelemede}
    public enum Editorıncele {Reddedildi,Düzenlenecek,Onaylandı}
    public class Kisi

    {private string ad;
       private string soyad;
        public Kisi(string ad, string soyad)
        {this.ad = ad;
         this.soyad = soyad;

        } 
        public string Ad
        {get { return ad; }

            set { ad = value; }
        } 
        public string Soyad

        {

            get { return soyad; }

            set { soyad = value; }

        }} 
    public class Yayinevi

  {

    string isim;

    private List<Kitap> kitaplar;

    private List<Editor> editorler;

    public Yayinevi(string isim)

    {

      this.isim = isim;

      kitaplar = new List<Kitap>();

      editorler = new List<Editor>();

    }

    public void addKitap(Kitap k)

    {

      kitaplar.Add(k);

    }

    public void removeKitap(Kitap k)

    {

      kitaplar.Remove(k);

    }

    public void addEditor(Editor e)

    {

      editorler.Add(e);

    }

    public void removeEditor(Editor e)

    {

      editorler.Remove(e);

    }

    public Editor[] getEditorler()

    {

      Editor[] dizi = new Editor[editorler.Count];

      int i = 0;

      foreach (Editor e in editorler)

      {

        dizi[i] = e;

        i++;

      }

      return dizi;

    }

  }
    public class Kitap

  {

    private Yazar yazar;

    private List<KitapInceleme> incelemeler;

    private KitapDurumEnum durum;

    private String adi;

    public Kitap(Yazar yazar, string adi)

    {

      this.yazar = yazar;

      this.adi = adi;

      incelemeler = new List<KitapInceleme>();

    }

    public Yazar Yazar { get { return yazar; } }

    public string Adi { get { return adi; } }

        public KitapDurumEnum Durum { get { return durum; } }

    public void addInceleme(KitapInceleme inceleme)

    {

      incelemeler.Add(inceleme);

      kitapDurumGuncelle();

    }

    public void removeInceleme(KitapInceleme inceleme)

    {

      incelemeler.Remove(inceleme);

      kitapDurumGuncelle();

    }

    public void kitapDurumGuncelle()

    {

      KitapInceleme sonInceleme = incelemeler[incelemeler.Count - 1];

      if (sonInceleme.getKarar() == EditorInceleEnum.REDDEDILDI)

        durum = KitapDurumEnum.REDDEDILDI;

      else if (sonInceleme.getKarar() == EditorInceleEnum.DUZENLENECEK)

        durum = KitapDurumEnum.INCELEMEDE;

      else if (sonInceleme.getKarar() == EditorInceleEnum.ONAYLANDI)

        durum = KitapDurumEnum.YAYINLANDI;

    }



  }
    public class KitapInceleme

  {

    private List<EditorKitapGorus> gorusler;

    private Kitap kitap;

    public KitapInceleme(Kitap kitap)

    {

      gorusler = new List<EditorKitapGorus>();

      this.kitap = kitap;

    }

    public void addKitapGorus(Editor editor,string aciklama,EditorInceleEnum karar)

    {

      gorusler.Add(new EditorKitapGorus(editor, aciklama, karar));

    }

    public EditorInceleEnum getKarar()

    {

      EditorInceleEnum sonuc = 0;

      int red = 0, duzenlenecek = 0, onay = 0;

      for(int i = 0; i < gorusler.Count; i++)

      {

        EditorInceleEnum karar = gorusler[i].Karar;

        if (karar == EditorInceleEnum.REDDEDILDI) red++;

        else if (karar == EditorInceleEnum.ONAYLANDI) onay++;

        else duzenlenecek++;

      }

      if (red > 0) sonuc = EditorInceleEnum.REDDEDILDI;

      else if (duzenlenecek > 0) sonuc = EditorInceleEnum.DUZENLENECEK;

      else if (onay > 0 && onay == gorusler.Count) sonuc = EditorInceleEnum.ONAYLANDI;

      return sonuc;

    }

        internal void AddKitapGorus(Editor e1, string v, EditorInceleEnum oNAYLANDI)
        {
            throw new NotImplementedException();
        }
    }
    
    public enum EditorInceleEnum { REDDEDILDI,DUZENLENECEK,ONAYLANDI}

  public class EditorKitapGorus

  { 

    private Editor editor;

    private string aciklama;

    private EditorInceleEnum karar;

    public EditorKitapGorus(Editor editor,string aciklama,EditorInceleEnum karar)

    {

      this.editor = editor;

      this.aciklama = aciklama;

      this.karar = karar;

    }

    public Editor Editor

    {

      get { return editor; }

    }

    public string Aciklama { get { return aciklama; } }

    public EditorInceleEnum Karar { get { return karar; } }

  }
    
    public class Yazar:Kisi

  {

    public Yazar(string ad,string soyad):base(ad,soyad)

    {       

    }

  }
  public class Editor:Kisi

  {

    public Editor(string ad, string soyad) : base(ad, soyad)

    {



    }

  }
    internal class Program
    {
        static void Main(string[] args)
        {
            Yayinevi yayinevi = new Yayinevi("Alfa");

            Editor e1 = new Editor("Ahmet", "Görür");

            Editor e2 = new Editor("Ali", "Bilgili");

            yayinevi.addEditor(e1); yayinevi.addEditor(e2);

            Yazar y1 = new Yazar("Veli", "CAN");

            Kitap k1 = new Kitap(y1, "Güneşli bir gün");

            KitapInceleme ki = new KitapInceleme(k1);

            ki.AddKitapGorus(e1, "Giris bolumu duzeltilmeli", EditorInceleEnum.ONAYLANDI);

            ki.AddKitapGorus(e2, "", EditorInceleEnum.REDDEDILDI);

            k1.addInceleme(ki);

            Console.WriteLine(k1.Durum);





            Console.ReadKey();

        }
    }
    }

