using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //söz dizilimi
            // Class SınifAdi
            // {
            //      [erişim Belirleyici] [Veri Tipi] Özellikadi;
            //      [erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([parametre listesi]);
            //      {
            //      Metot Komutları
            //      }
            // }
            // Erişim belirleyiciler
            //*Public Her yerden erişilebilir.
            //*Private Sadece tanımlandığı sınıf içerisinden erişilebilir.
            //*Protected  Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir
            //*Interval Sadece bulunduğu proje içerisinden erişilebilir
            Calisan calisan1=new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=2235634;
            calisan1.Departman="İnsan Kaynakları";

            calisan1.CalisanBilgileri();
            Console.WriteLine("**********");

            Calisan calisan2=new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}" , Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}" , Soyad);
            Console.WriteLine("Çalışanın No: {0}" , No);
            Console.WriteLine("Çalışanın Departmanı: {0}" , Departman);
        }
    }
}
   