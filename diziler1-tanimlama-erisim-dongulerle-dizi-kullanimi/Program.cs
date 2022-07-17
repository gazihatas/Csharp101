using System;

namespace diziler1_tanimlama_erisim_dongulerle_dizi_kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***
             * Diziler : Aynı tipteki değişkenleri bellekte arka arkaya saklamak istediğimizde dizileri kullanırız.
             * Dizinin elemanlarının veri tipleri herzaman aynı olur. Yani string bir dizi tanımladığınızda onun içerisinen integer bir veri atamazsınız.
             * Diziler 0. elamandan başlar.
             * 
             * 
             * **/

            //Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını alan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz :", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;

            }
            Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);
        }
    }
}
