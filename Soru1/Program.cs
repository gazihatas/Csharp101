using System;
using System.Collections;
using System.ComponentModel.Design;

namespace Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            
            //listelere elemanları atamaya başladık
            Console.Write("Sayıları Girin : ");
            for (int j = 0; j < 20; j++)
            {
                try
                {
                    int sayi = int.Parse(Console.ReadLine());
                    int sayac = 0;
                    if (sayi > 0 && !sayi.Equals(typeof(int)))
                    {
                        for (int i = 2; i < sayi; i++)
                        {
                            if (sayi % i == 0)
                            {
                                sayac++;
                            }
                        }
                        if (sayac == 0)
                        {
                            asalSayilar.Add(sayi);
                        }
                        else
                        {
                            asalOlmayanSayilar.Add(sayi);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen pozitif sayı değeri giriniz");
                    }
                }
                catch
                {

                    Console.WriteLine("Hatalı değer girdiniz lütfen pozitif tam sayı değeri giriniz");
                }

            }

            Console.WriteLine("******************************");
            int sayacAsalSayi = 0;

            //listelere elemanları atamayı bitirdik

            //Kaçar tane asal ve asal olmayan sayı var 
            foreach (var item in asalSayilar)
            {
                sayacAsalSayi++;
            }
            int sayacAsalOlmayanSayi = 0;

            foreach (var item in asalOlmayanSayilar)
            {
                sayacAsalOlmayanSayi++;
            }

            Console.WriteLine("Asal Olan Sayılar Toplam: " + sayacAsalSayi + " Adet");
            Console.WriteLine("Asal Olmayan Sayılar Toplam: " + sayacAsalOlmayanSayi + " Adet");
            // Kaç tane olduğunu bulduk

            Console.WriteLine("******************************");

            //büyükten küçüğe olacak şekilde sıraladığımız kısım


            for (int i = 0; i < sayacAsalSayi; i++)
            {

                for (int j = 0; j < sayacAsalSayi - 1; j++)
                {
                    if ((int)asalSayilar[i] > (int)asalSayilar[j])
                    {
                        int temp = (int)asalSayilar[i];
                        asalSayilar[i] = (int)asalSayilar[j];
                        asalSayilar[j] = temp;
                    }
                }


            }




            for (int i = 0; i < sayacAsalOlmayanSayi; i++)
            {

                for (int j = 0; j < sayacAsalOlmayanSayi - 1; j++)
                {
                    if ((int)asalOlmayanSayilar[i] > (int)asalOlmayanSayilar[j])
                    {
                        int temp = (int)asalOlmayanSayilar[i];
                        asalOlmayanSayilar[i] = (int)asalOlmayanSayilar[j];
                        asalOlmayanSayilar[j] = temp;
                    }
                }


            }

            //büyükten küçüğe sıralama bitti

            Console.Write("Asal sayılar: ");
            foreach (int item in asalSayilar)
            {
                Console.Write(item + " ,");
            }

            Console.WriteLine(" ");
            Console.Write("Asal olmayan sayılar: ");
            foreach (int item in asalOlmayanSayilar)
            {
                Console.Write(item + " ,");
            }


            //ortalama alma 
            Console.WriteLine(" ");
            int asalOlmayanToplam = 0;
            for (int j = 0; j < sayacAsalOlmayanSayi; j++)
            {
                asalOlmayanToplam += (int)asalOlmayanSayilar[j];

            }

            int asalToplam = 0;
            for (int j = 0; j < sayacAsalSayi; j++)
            {
                asalToplam += (int)asalSayilar[j];

            }

            if (sayacAsalSayi > 0)
            {
                double asalOrtalama = asalToplam / sayacAsalSayi;
                Console.WriteLine("Asal Sayıların Ortalaması: " + asalOrtalama);
            }
            if (sayacAsalOlmayanSayi > 0)
            {
                double asalOlmayanOrtalama = asalOlmayanToplam / sayacAsalOlmayanSayi;
                Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + asalOlmayanOrtalama);
            }





        }

        private static bool IsPrimeNumber(int number)
        {

            //kendisi ve  hariç tam böleni olmayan sayıdır.

            bool result = true;

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
