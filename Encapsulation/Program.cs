using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Encapsulation => kapsamak, korumak
             * kapsülleme bir nesnenin bazı özelliklerini, işlevlerini, metotlarını diğer classlardan ve diğer nesnelerden korumak anlamına gelir.
             * Bu koruma işlemi erişim belirleyiciler sayesinde yapılır.
             *
             * propertyler yardımıyla (get ve set olarak da bilinir.)   encapsuılaton kullanarak sınıfın üyelerini fieldlarını kapatabiliriz. değişimini
             * engelleyebiliriz koruyabiliriz.
             *
             * get => o property nin private fieldnin değerini get eden
             *
             * set => o property nin private fieldnin değerini set eden
             */

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Gazi";
            ogrenci.Soyisim = "Hatas";
            ogrenci.OgrenciNo = 158;
            ogrenci.Sinif = 11;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }


        class Ogrenci
        {
            private string isim;
            private string soyisim;
            private int ogrenciNo;
            private int sinif;

            public string Isim
            {
                get { return isim; }
                set { isim = value; }
            }

            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

            public int Sinif
            {
                get => sinif;
                set
                {
                    if (value < 1)
                    {
                        Console.WriteLine("Sınıf En Az 1 Olabilir!");
                    }
                    else
                    {
                        sinif = value;
                    }
                    sinif = value;
                }
            }


            public Ogrenci(String isim, string soyisim, int ogrenciNo, int sinif)
            {
                Isim = isim;
                Soyisim = soyisim;
                OgrenciNo = ogrenciNo;
            }

            public Ogrenci() {}

            public void OgrenciBilgileriniGetir()
            {
                Console.WriteLine("**** Öğrenci Bilgileri *****");
                Console.WriteLine("Öğrenci Adı         :{0}",this.Isim);
                Console.WriteLine("Öğrenci Soyadı      :{0}",this.Soyisim);
                Console.WriteLine("Öğrenci No          :{0}",this.OgrenciNo);
                Console.WriteLine("Öğrenci Sınıfı      :{0}",this.Sinif);

            }

            public void SinifAtlat()
            {
                this.Sinif = this.Sinif + 1;
            }

            public void SinifDusur()
            {
                this.Sinif = this.Sinif - 1;
            }

        }
    }
}
