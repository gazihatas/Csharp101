using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmaSorular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            questions soru = new questions();
            soru.ciftOlanlariYazdir();
            soru.tamBolunenleriYazdir();
            soru.sondanBasaYazdir();
            soru.kelimeVeHarfSayisi();

            Console.ReadLine();
        }
    }


    public class questions
    {
        public void ciftOlanlariYazdir()
        {
            Console.WriteLine("*** ÇİFT SAYILARI EKRANA YAZDIRMA ***");
            Console.Write("Sayi Adedini Giriniz : ");
            string lines = Console.ReadLine();
            List<int> nums = new List<int>();
            for (int i = 0; i < int.Parse(lines); i++)
            {
                Console.Write("{0}. Sayıyı Giriniz : ", i+1);
                int line = int.Parse(Console.ReadLine());
                if (line % 2 == 0) nums.Add(line);
            }

            foreach (var j in nums)
            {
                Console.Write("Girmiş olduğunuz çif sayılar : " + j);
            }
        }

        public void tamBolunenleriYazdir()
        {
            Console.WriteLine("*** GİRİLEN SAYILARDAN EŞİT YADA TAM BÖLÜNENELERİ EKRANA YAZDIRMA ***");
            Console.Write("Bolunen Sayiyi Giriniz : ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Sayi Adedini Giriniz : ");
            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Sayi Giriniz : ");
                int num = int.Parse(Console.ReadLine());
                if (m % num == 0) nums.Add(num);
            }

            foreach (var j in nums)
            {
                Console.WriteLine(j);
            }
        }

        public void sondanBasaYazdir()
        {
            Console.WriteLine("*** KELİMELERİ SONDAN BASA YAZDIRMA EKRANA YAZDIRMA ***");
            Console.Write("Kelime Adedini Giriniz : ");
            int n = int.Parse(Console.ReadLine());

            List<string> kelimeler = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Sayi Giriniz : ");
                string kelime = Console.ReadLine();
                kelimeler.Add(kelime);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
        }

        public void kelimeVeHarfSayisi()
        {
            Console.WriteLine("*** CÜMLEDEKİ TOPLAM KELİME VE HARF SAYISINI EKRANA YAZDIRMA ***");
            Console.Write("Cümle Giriniz : ");
            string cumle = Console.ReadLine();

            string[] words = cumle.Split(' ');
            Console.WriteLine("Kelime Sayisi : {0}", words.Count());

            Console.WriteLine("Harf Sayisi : {0}", cumle.Count());

        }
    }
}
