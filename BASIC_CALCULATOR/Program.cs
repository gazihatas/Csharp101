using System;

namespace BASIC_CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *
             *Kullanıcıdan yapmak istediği işlem istenir:
• Toplama için 1
• Çıkarma için 2
• Çarpma için 3
• Bölme için 4
• Mod alma için 5
• Çıkış için 0
Seçilen işlem 1,2,3 ve 4 için 2 adet double sayı istenir.
Seçilen işlem 5 için 2 adet integer sayı istenir.
Kullanıcı sayıları girdikten sonra sonuç ekrana gösterilir.
Kullanıcı 0 seçene kadar işlem istenmeye devam edilir.
Kullanıcının 0 seçmesi durumunda program sonlandırılır.
! Bölme işleminde bölen 0 olamaz kontrolü yapılmalıdır.
! İşlem seçimi bölümünde mevcut seçenekler dışında bir değer girilemez kontrolü yapılmalıdır.
! Sayı girilen yerlerde string veya char değer girilemez. Girilmesi durumunda kullanıcı uyarılır ve
yalnızca yanlış girilen değer kullanıcıdan doğrusu girilene kadar tekrar istenir. 
             *
             *
             */


            Console.WriteLine("***** BASİT HESAP MAKİNESİ *****");
            Console.WriteLine("Toplama için 1");
            Console.WriteLine("Çıkarma için 2");
            Console.WriteLine("Çarpma için 3");
            Console.WriteLine("Bölme için 4");
            Console.WriteLine("Mod alma için 0");
            int secim = Convert.ToInt32(Console.ReadLine());

            
        }

        public class AritmetikIslemler
        {
            public double topla(double sayi1, double sayi2)
            {
                double toplam = sayi1 + sayi2;
                return toplam;
            }

            public double cikar(double sayi1, double sayi2)
            {
                double fark = sayi1 - sayi2;
                return fark;
            }

            public double carp(double sayi1, double sayi2)
            {
                double carpim = sayi1 * sayi2;
                return carpim;
            }

            public double bolme(double sayi1, double sayi2)
            {
                double bolum = sayi1 / sayi2;
                
                return bolum;
            }


            
        }
    }
}
