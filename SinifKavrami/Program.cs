using System;

namespace SinifKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erişim Belirleyiciler
            /*
             * Public => Heryerden erişilebilir.
             * Private => Sadece tanımlandığı sınıf içerisinden erişilebilir.
             * Internal => sadece kendi bulunduğu proje dosyası içersinde erişilebilen değişkenlere metotlara internal diyebiliriz.
             * Protected =>  sadece tanımlandığı sınıfta ve o sınıftan kalıtım alan sınıflarda kullanılır.
             *    1. Public : Her yerden erişilebilir.

                 2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

                 3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

                 4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
             */

            Calisan calisan1 = new Calisan();
           calisan1.Ad = "Gazi";
           calisan1.Soyad = "Hataş";
           calisan1.No = 25555544;
           calisan1.Departman = "Web teknolojileri";
           calisan1.CalisanBilgileri();
           Console.WriteLine("***********");

           Calisan calisan2 = new Calisan();
           calisan2.Ad = "Lego";
           calisan2.Soyad = "frmo";
           calisan2.No = 25555544;
           calisan2.Departman = "Web teknolojileri";
           calisan2.CalisanBilgileri();
           Console.WriteLine("***********");


        }

        class Calisan
        { 
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışanın Adı: {0}", Ad);
                Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
                Console.WriteLine("Çalışanın Numarası: {0}", No);
                Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
            }
        }
    }
}
