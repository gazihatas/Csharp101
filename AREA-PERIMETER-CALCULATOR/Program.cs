using System;
using System.ComponentModel;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace AREA_PERIMETER_CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            geometrikAlanCevre instance = new();

            Console.WriteLine("***** ALAN ÇEVRE HESAPLAYI *****");
            Console.WriteLine("Hesaplamak için 1 tuşuna basın.");
            Console.WriteLine("Çıkış için 0 tuşuna basın.");
            int secim = Int32.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("***** İŞLEM SEÇİMİ *****");
                    Console.WriteLine("Alan için 1");
                    Console.WriteLine("Çevre için 2");
                    int hesaplamaSecim = Int32.Parse(Console.ReadLine());
                    switch (hesaplamaSecim)
                    {
                        case 1:
                            Console.WriteLine("**** ALANI HESAPLANACAK GEOMETRİK ŞEKİL SEÇME ****");
                            Console.WriteLine("Üçgen için 1");
                            Console.WriteLine("Kare için 2");
                            Console.WriteLine("Dikdörtgen için 3");
                            Console.WriteLine("Daire için 4");
                            int alanSecim = Int32.Parse(Console.ReadLine());
                            switch (alanSecim)
                            {
                                case 1:
                                    Console.WriteLine("***** ÜÇGEN TİPİ*****");
                                    Console.WriteLine("EŞKENAR ÜÇGEN 1");
                                    Console.WriteLine("İKİZKENAR ÜÇGEN 2");
                                    Console.WriteLine("ÇEŞİTKENAR ÜÇGEN 3");

                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            Console.WriteLine("***** EŞKENAR ÜÇGEN ALANI HESAPLAMA");
                                            Console.WriteLine("Lütfen kenar değerini giriniz");
                                            int esKenarUcgenKenar = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Lütfen yükseklik değerini giriniz");
                                            int esKenarUcgenYukseklik = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Eşkenar Üçgenin Alanı: {0}" , instance.eskenarUcgenAlan(esKenarUcgenKenar, esKenarUcgenYukseklik));
                                            break;
                                        case "2":
                                            break;
                                        case "3":
                                            Console.WriteLine("***** ÇEŞİTKENAR ÜÇGEN ALANI HESAPLAMA");
                                            Console.WriteLine("Lütfen 1. kenar değerini giriniz");
                                            int birinciKenar = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Lütfen 2. kenar değerini giriniz");
                                            int ikinciKenar = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Lütfen 3. kenar değerini giriniz");
                                            int ucuncuKenar = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Çeşitkenar Üçgenin Alanı: {0}", instance.cesitKenarUcgenAlani(birinciKenar,ikinciKenar,ucuncuKenar));
                                            break;
                                        default:
                                            Console.WriteLine("Lütfen geçerli bir değer giriniz");
                                            break;
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Karenin bir kenarını giriniz.");
                                    int kenar = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Karenin Alanı {0}", instance.kareAlanBul(kenar));
                                    break;
                                case 3:
                                    Console.WriteLine("Kısa kenarı giriniz.");
                                    int kisaKenar = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Uzunkenarı giriniz.");
                                    int uzunKenar = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Dikdörtgenin Alanı {0}", instance.AlanBul(kisaKenar, uzunKenar));
                                    break;
                                case 4:
                                    Console.WriteLine("Yarıçapı giriniz");
                                    double yariCap = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Dairenin Alanı : {0}", instance.daireAlan(yariCap));
                                    break;
                                default:
                                    Console.WriteLine("Lütfen geçerli değer giriniz.");
                                    break;
                            }
                                break;
                        case 2:
                            Console.WriteLine("**** ÇEVRESİ HESAPLANACAK GEOMETRİK ŞEKİL SEÇME ****");
                            Console.WriteLine("Üçgen için 1");
                            Console.WriteLine("Kare için 2");
                            Console.WriteLine("Dikdörtgen için 3");
                            Console.WriteLine("Daire için 4");
                            int cevreSecim = Int32.Parse(Console.ReadLine());
                            switch (cevreSecim)
                            {
                                case 1:
                                    break;
                                case 2:
                                    Console.WriteLine("Karenin bir kenarını giriniz.");
                                    int kenar = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Karenin Çevresi {0}", instance.kareCevreBul(kenar));
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Kısa kenarı giriniz.");
                                    int kisaKenar = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Uzunkenarı giriniz.");
                                    int uzunKenar = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Dikdörtgenin Çevresi {0}", instance.CevreBul(kisaKenar, uzunKenar));
                                    break;
                                case 4:
                                    Console.WriteLine("Yarıçapı giriniz");
                                    double yariCap = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Dairenin Çevre : {0}", instance.daireCevre(yariCap));
                                    break;
                                default:
                                    Console.WriteLine("Lütfen geçerli değer giriniz.");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                            Console.ReadKey();
                            break;
                    }
                    break;
                case 0:
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                    break;
            }

            


        }

    }


    public class geometrikAlanCevre
    {

        //Dikdörtgen
        public int AlanBul(int kisakenar, int uzunkenar)
        {
            int alan = kisakenar * uzunkenar;
            return alan;
        }
        public int CevreBul(int kisakenar, int uzunkenar)
        {
            int cevre = 2 * (kisakenar + uzunkenar);
            return cevre;
        }

        //Kare
        public int kareAlanBul(int kenar)
        {
            int kareAlan = kenar * kenar;
            return kareAlan;
        }
        public int kareCevreBul(int kenar)
        {
            int kareCevre = kenar * 4;
            return kareCevre;
        }

        //daire
        public double daireAlan(double yariCap)
        {
            const double pi = 3.14;
            double alan = pi * yariCap * yariCap;
            return alan;
        }

        public double daireCevre(double yariCap)
        {
            const double pi = 3.14;
            double cevre = 2 * pi * yariCap;
            return cevre;
        }

        //Eşkenar Üçgen
        public int eskenarUcgenAlan(int kenar, int yukseklik)
        {
            int alan = (kenar * yukseklik) / 2;
            return alan;
        }

        public int eskenarUcgenCevre(int kenar)
        {
            int cevre = kenar * 3;
            return cevre;
        }

        //Çeşitkenar ücgen
        public int cesitKenarUcgenAlani(int a, int b, int c)
        {
            /*
            int a, b, c, u, cevre;
            double alan;
            System.out.println("1.kenari gir: ");
            a = inp.nextInt();
            System.out.println("2.kenari gir: ");
            b = inp.nextInt();
            System.out.println("3.kenari gir: ");
            c = inp.nextInt();

            cevre = a + b + c;
            u = cevre / 2;
            alan = Math.sqrt((u * (u - a) * (u - b) * (u - c)));
            System.out.println("Üçgenin alani: " + alan);
        
            */
            int cevre = a+ b+c;
            int u = cevre / 2;
            double alan = Math.Sqrt((u * (u - a) * (u - b) * (u - c)));
            return (int)alan;
        }
    }
}
