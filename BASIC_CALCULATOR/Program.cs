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

            AritmetikIslemler instance = new();
            char cikis = 'h';
            do
            {
                Console.Clear();
                Console.WriteLine("***** BASİT HESAP MAKİNESİ *****");
                Console.WriteLine("Toplama için 1");
                Console.WriteLine("Çıkarma için 2");
                Console.WriteLine("Çarpma için 3");
                Console.WriteLine("Bölme için 4");
                Console.WriteLine("Mod alma için 5");
                Console.WriteLine("Çıkış için 0");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 0: 
                            cikis = 'e';
                        break;
                    case 1:
                        Console.WriteLine("***** TOPLAMA İŞLEMİ *****");
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        double sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        double sayi2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Toplam : {0}", instance.topla(sayi1,sayi2));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("***** ÇIKARMA İŞLEMİ *****");
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        double sayi3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        double sayi4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("FARK : {0}", instance.cikar(sayi3, sayi4));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("***** ÇARPMA İŞLEMİ *****");
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        double sayi5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        double sayi6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Toplam : {0}", instance.carp(sayi5, sayi6));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("***** BÖLME İŞLEMİ *****");
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        double sayi7 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        double sayi8 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Toplam : {0}", instance.bolme(sayi7, sayi8));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("***** MOD ALMA İŞLEMİ *****");
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        int sayi9 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        int sayi10 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Toplam : {0}", instance.carp(sayi9, sayi10));
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("mevcut seçenekler dışında bir değer girilemez");
                        break;
                }

            } while (cikis != 'h');
               

            
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

            public int mod(int sayi1, int sayi2)
            {
                int mod = sayi1 % sayi2;
                return mod;
            }


            
        }
    }
}
