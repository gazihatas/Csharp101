using System;
using System.Net.Mime;

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
    }
}
