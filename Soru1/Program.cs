using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Net.Http;

namespace Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
             * (ArrayList sınıfını kullanara yazınız.)

            Negatif ve numeric olmayan girişleri engelleyin.
            Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            */
            
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();

            for (int i = 1; i <= 20; i++)
            {
                try
                {
                    int sayi = int.Parse(Console.ReadLine());
                    int sayac = 0;
                    if(IsPrimeNumber(sayi)==true && !sayi.Equals(typeof(int)))
                    {
                        asalSayilar.Add(sayi);
                    }
                    else if(IsPrimeNumber(sayi)==false && !sayi.Equals(typeof(int)))
                    {
                        asalOlmayanlar.Add(sayi);
                    }
                    else
                    {
                        Console.WriteLine("Pozitif sayı girin.");
                    }
                
                }
                catch 
                {
                    Console.WriteLine("Lütfen pozitif sayı girin!");
                }
            }
            //Sayi girişleri ve listelere atamalar yapıldı.

            
            Console.WriteLine("------------------------------------>");
            
            asalSayilar.Reverse();
            int asalSayac = 0;
            int asalToplam = 0;
            //Asal arraylist' i içerisindeki sayıları döndürme
            Console.WriteLine("Girilen Asal Sayılar :");
            foreach (var asal in asalSayilar)
            {
                Console.Write(" {0}, ", asal);
                asalSayac++;
            }
            //Asal array listindeki elemanların toplamı
            for (int i = 0; i < asalSayilar.Count; i++)
            {
                asalToplam += (int)asalSayilar[i];
            }
            
            Console.WriteLine("---------------------->");
            asalOlmayanlar.Reverse();
            //int asalOlmayanSayac = 0;
            int asalOlmayanToplam = 0;
            Console.WriteLine("Girilen Asal Sayı Olmayan Sayılar : ");
            foreach (var asalOlmayan in asalOlmayanlar)
            {
                Console.Write("{0}, ",asalOlmayan);
                //asalOlmayanSayac++;
            }

            for (int i = 0; i < asalOlmayanlar.Count; i++)
            {
                asalOlmayanToplam += (int)asalOlmayanlar[i];
            }
            Console.WriteLine("------------------------------------>");

            Console.WriteLine("***** ASAL ******");
            Console.WriteLine("Asal Sayıların Toplamı : {0}",asalToplam);
            Console.WriteLine("{0} adet asal sayı vardır.",asalSayilar.Count);

            Console.WriteLine("**** ASAL OLMAYAN *****");
            Console.WriteLine("Asal Sayı Olmayan Sayıların Toplamı : {0}", asalOlmayanlar.Count);
            Console.WriteLine("{0} adet asal OLMAYAN sayı vardır.", asalOlmayanlar.Count);

        }


        //Asal sayı olup olmadıgını kontrol eden fonksiyonumuz
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
