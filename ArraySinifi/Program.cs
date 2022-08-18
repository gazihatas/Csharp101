using System;

namespace ArraySinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Sayilar = new int[5];
            Sayilar[0] = 21;
            Sayilar[1] = 22;
            Sayilar[2] = 23;
            Sayilar[3] = 24;
            Sayilar[4] = 25;

            #region Özellikler

            #region IsFixedSize
            //Dizideki eleman sayıısının sabit olup olmadığını bildirir.
            Console.WriteLine(Sayilar.IsFixedSize);
            #endregion

            #region IsReadOnly
            //Dizideki elemanların sadece okunabilir olup olmadığını bildirir.
            Console.WriteLine(Sayilar.IsReadOnly);

            #endregion

            #region Length
            //Dizinin eleman sayısını verir.
            Console.WriteLine(Sayilar.Length);
            #endregion

            #region Rank
            //Dizinin  boyutunu verir.
            Console.WriteLine(Sayilar.Rank);
            #endregion

            #endregion

            #region Metodlar

            #region Clear
            //Dizinin elemanlarının değerini varsayılan yapar.
            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }
            Console.WriteLine("*******************");
            Array.Clear(Sayilar, 0, Sayilar.Length);
            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }
            #endregion

            #region Copy
            //Dizinin istenilen eleman aralığını başka bir diziye kopyalar.
            int[] Sayilar2 = new int[3];

            for (int i = 0; i < Sayilar2.Length; i++)
            {
                Console.WriteLine(Sayilar2[i]);
            }
            Console.WriteLine("*************");
            Array.Copy(Sayilar, Sayilar2, 3);
            for (int i = 0; i < Sayilar2.Length; i++)
            {
                Console.WriteLine(Sayilar2[i]);
            }
            #endregion

            #region IndexOf
            //Dizi içinde harf ya da kelime aramamıza yarar. Eğer harf ya da kelimeyi bulursa bulduğu ilk indexi gönderir. Bulamazsa geriye -1 gönderir.
            Console.WriteLine(Array.IndexOf(Sayilar, 25));

            #endregion

            #region Reverse
            //Diziyi ters çevirir.
            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }
            Console.WriteLine("*******************");
            Array.Reverse(Sayilar);
            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }


            #endregion

            #region Sort
            //Dizi eleamlarını sıralar
            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }
            Console.WriteLine("*******************");
            Array.Sort(Sayilar);
            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }

            #endregion

            #endregion

            Console.Read();
        }
    }
}
