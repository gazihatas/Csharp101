using System;

namespace type_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Implicit Conversion****");
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            //Tanım: Düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanma işlemidir.
            //Herhangi bir çevrim kodu parse ve convert yazmanıza gerek yoktur.
            //Çevirim işlemini sizin yerinize makine yapar.

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;//integer veri türünün kapasitesi yukarıdaki veri türlerinin kapasitesinden daha fazladır. kapasite uyumsuzluğu olsaydı bu işlem gerçekleşmezdi.
            Console.WriteLine("d:" + d);

            long e = d;
            Console.WriteLine("e:" + e);

            float f = e;
            Console.WriteLine("f:" + f);

            string g = "Gazi";
            char h = 'g';
            object ı = g + h + d;
            Console.WriteLine("ı:" + ı);

            Console.WriteLine("****Explicit Conversion****");
            //Explicit Conversion (Bilinçli Dönüşüm)
            //Tanım: csharp kendi kendine yapamadığı dönüşümlerdir. Sizin Convert, parse ve ToString kullanarak derleyiciye dönüşümleri ifade ederiz.
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            Console.WriteLine("**** ToString Methodu****");
            //ToString Methodu

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            Console.WriteLine("****System.Convert Sınıfı****");
            //System.Convert Sınıfı

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            Console.WriteLine("****Parse Methodu****");
            //Parse Methodu
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1); //Parse string ifadeleri dönüştürmek için kullanılır ve her zaman string değer türü alır.
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 :" + rakam1);
            Console.WriteLine("double1:" + double1);   
        }
    }
}
