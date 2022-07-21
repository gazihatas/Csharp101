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
            char cikis = 'e';
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

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 0: 
                            cikis = 'h';
                        break;
                    case 1:
                        Console.WriteLine("***** TOPLAMA İŞLEMİ *****");
                       
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        string sayi1 = Console.ReadLine();
                        double number;
                        bool result = double.TryParse(sayi1, out number);

                       
                        if (result)
                        {
                           // Console.WriteLine("{0}, Bu bir rakamdır. Lütfen bir rakam giriniz.", sayi1);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi1);
                            Console.WriteLine("Lütfen 1. sayıyı tekrar giriniz");
                            sayi1 = Console.ReadLine();
                        }

                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        string sayi2 = Console.ReadLine();
                        bool result2 = double.TryParse(sayi2, out number);
                        if (result2)
                        {
                           // Console.WriteLine("{0}, Bu bir rakamdır", sayi2);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi2);
                            Console.WriteLine("Lütfen 2. sayıyı tekrar giriniz");
                            sayi2 = Console.ReadLine();
                        }

                        Console.WriteLine("Toplam : {0}", instance.topla(Convert.ToDouble(sayi1),Convert.ToDouble(sayi2)));
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("***** ÇIKARMA İŞLEMİ *****");
                        
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        string sayi3 = Console.ReadLine();
                        double number2;
                        bool result3 = double.TryParse(sayi3, out number2);
                        if (result3)
                        {
                            // Console.WriteLine("{0}, Bu bir rakamdır. Lütfen bir rakam giriniz.", sayi1);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi3);
                            Console.WriteLine("Lütfen 1. sayıyı tekrar giriniz");
                            sayi3 = Console.ReadLine();
                        }

                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        string sayi4 = Console.ReadLine();
                        bool result4 = double.TryParse(sayi4, out number2);
                        if (result4)
                        {
                            // Console.WriteLine("{0}, Bu bir rakamdır", sayi2);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi4);
                            Console.WriteLine("Lütfen 2. sayıyı tekrar giriniz");
                            sayi4 = Console.ReadLine();
                        }

                        Console.WriteLine("FARK : {0}", instance.cikar(Convert.ToDouble(sayi3), Convert.ToDouble(sayi4)));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("***** ÇARPMA İŞLEMİ *****");
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        string sayi5 = Console.ReadLine();
                        double number3;
                        bool result5 = double.TryParse(sayi5, out number3);
                        if (result5)
                        {
                            // Console.WriteLine("{0}, Bu bir rakamdır. Lütfen bir rakam giriniz.", sayi1);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi5);
                            Console.WriteLine("Lütfen 2. sayıyı tekrar giriniz");
                            sayi5 = Console.ReadLine();
                        }

                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        string sayi6 = Console.ReadLine();
                        bool result6 = double.TryParse(sayi6, out number3);
                        if (result6)
                        {
                            // Console.WriteLine("{0}, Bu bir rakamdır", sayi2);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi6);
                            Console.WriteLine("Lütfen 2. sayıyı tekrar giriniz");
                            sayi6 = Console.ReadLine();
                        }

                        Console.WriteLine("Çarpım : {0}", instance.carp(Convert.ToDouble(sayi5),Convert.ToDouble(sayi6)));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("***** BÖLME İŞLEMİ *****");
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        string sayi7 = Console.ReadLine();
                        double number4;
                        bool result7 = double.TryParse(sayi7, out number4);
                        if (result7)
                        {
                            // Console.WriteLine("{0}, Bu bir rakamdır. Lütfen bir rakam giriniz.", sayi1);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi7);
                            Console.WriteLine("Lütfen 1. sayıyı tekrar giriniz");
                            sayi7 = Console.ReadLine();
                        }

                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        string sayi8 = Console.ReadLine();
                        if (Convert.ToDouble(sayi8) == 0)
                        {
                            Console.WriteLine("Bölen sıfır olamaz.");
                            Console.WriteLine("Lütfen 2. sayıyı tekrar giriniz");
                            sayi8 = Console.ReadLine();
                            bool result8 = double.TryParse(sayi8, out number4);

                            if (result8)
                            {
                                // Console.WriteLine("{0}, Bu bir rakamdır", sayi2);
                            }
                            else
                            {
                                Console.WriteLine("{0}, Bu rakam değildir.", sayi8);
                                Console.WriteLine("Lütfen 2. sayıyı tekrar giriniz");
                                sayi8 = Console.ReadLine();
                            }
                        }
                        else
                        {
                            bool result8 = double.TryParse(sayi8, out number4);

                            if (result8)
                            {
                                // Console.WriteLine("{0}, Bu bir rakamdır", sayi2);
                            }
                            else
                            {
                                Console.WriteLine("{0}, Bu rakam değildir.", sayi8);
                                Console.WriteLine("Lütfen 2. sayıyı tekrar giriniz");
                                sayi8 = Console.ReadLine();
                            }
                        }
                        
                        Console.WriteLine("Bölüm : {0}", instance.bolme(Convert.ToDouble(sayi7), Convert.ToDouble(sayi8)));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("***** MOD ALMA İŞLEMİ *****");
                        Console.WriteLine("Lütfen 1. sayıyı giriniz");
                        string sayi9 = Console.ReadLine();
                        double number5;
                        bool result9 = double.TryParse(sayi9, out number5);
                        if (result9)
                        {
                            // Console.WriteLine("{0}, Bu bir rakamdır. Lütfen bir rakam giriniz.", sayi1);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi9);
                            Console.WriteLine("Lütfen 1. sayıyı tekrar giriniz");
                            sayi9 = Console.ReadLine();
                        }

                        Console.WriteLine("Lütfen 2. sayıyı giriniz");
                        string sayi10 = Console.ReadLine();
                        bool result10 = double.TryParse(sayi10, out number5);
                        if (result10)
                        {
                            // Console.WriteLine("{0}, Bu bir rakamdır", sayi2);
                        }
                        else
                        {
                            Console.WriteLine("{0}, Bu rakam değildir.", sayi10);
                            Console.WriteLine("Lütfen 2. sayıyı tekrar giriniz");
                            sayi10 = Console.ReadLine();
                        }

                        Console.WriteLine("Mod : {0}", instance.mod(Convert.ToInt32(sayi9),Convert.ToInt32(sayi10)));
                        Console.ReadKey();
                        break;
                    default :
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
