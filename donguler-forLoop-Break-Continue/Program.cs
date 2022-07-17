using System;

namespace donguler_forLoop_Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Döngüleri ne için kullanırız :
            //Belli bir kod bloğunun belli bir şartlara bağlı kalarak birden fazla çalışmasını istiyorsak for loop kullanmalıyız.

            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i%2 == 1)
                  Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i; //tekToplam = tekToplam + i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek Toplam " + tekToplam);
            Console.WriteLine("Cift Toplam " + ciftToplam);


            //break, continue => Dögülerle birlikte kullanılan özel iki tane keyworddür.
            
            // break => Eğer bir döngü içerisinde bir case'e bağlı olarak loop tan çıkmak istiyorsak yani döngüyü sonlandırmak istersek break ifadesini kullanırız.
            //break o an içinde olduğu loop u sonlandırır.
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            // continue => Eğer bir şarta bağlı olarak mevcut dögünün o sykılına atlamak istiyorsak  Mesela 10 kere dönecek fakat 1 şartta çalışmasını istemiyorsak 
            // sadece çalışmasını istemediğimiz saykılı atlayarak bir sonraki skyıla geçmesini sağlarız. Bunun için continue kullanırız.

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
