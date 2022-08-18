using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sınırlılıklar
            //Diziler oluşturulurken eleman sayısını vermek zorundayız.
            #endregion

            #region Dizi Tanımlama
            int[] Yaslar = new int[25];
            //string[] Isimler = new string[25];
            #endregion

            #region Değer Atama
            Yaslar[3] = 18;
            Yaslar[4] = 19;
            Yaslar[25] = 21;
            #endregion

            #region Değer Okuma
            Console.WriteLine(Yaslar[3]);
            #endregion

            //Length, dizinin eleman sayısını verir.
            #region Döngüyle Dizi İçerisinde Dönme

            for (int i = 0; i < Yaslar.Length; i++)
            {
                Yaslar[i] = i * 2;
            }

            for (int i = 0; i < Yaslar.Length; i++)
            {
                Console.WriteLine(Yaslar[i]);
            }
            #endregion

            #region Varyasyonlar
            int[] x = new int[] { 12, 5, 32, 2, 34, 234, 23, 234, 35, 32, 2, 23 };
            int[] y = {12,321,123};
            int[] z = new int[3] {3,2,3};
            #endregion

            Console.ReadLine();
        }
    }
}
