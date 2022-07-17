using System;

namespace metotlar2_metot_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                out parametreler => bir fonksiyona bir iş yaptırıp ve onun sonucunda bir değeri setlemesini istiyorsanız ve o setlediği şeyide kullanmak istiyorsanız. 
                Bunu out paremetre olarak verebilirsiniz.
             
             */
            string sayi = "999";

            bool sonuc = int.TryParse(sayi,out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yüklenme - Overloading
            //Metot Overloading => Biz bir fonkisyonun imzasını değiştirerek birden fazla şekilde o fonksiyonu  kullanabiliriz.

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Gazi", "Hataş");

            //Metot İmzası 
            //metotAdı + parametre sayısı + parametre
            

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b,out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }


    }
}
