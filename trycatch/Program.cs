using System;

namespace trycatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Derleme ve Mantıksal hatada trycatch yapısı kullanılmaz
            #region Derleme Hatası



            #endregion

            #region Mantıksal Hata


            #endregion


            //trycatch yapısının bu hata türünde kullanırız
            #region Çalışma Zamanı Hatası(Run Time)

            

            #endregion


            //try
            //{
            //    //Olası hata barındıran komutlarımız yazılır
            //}
            //catch (Exception e)
            //{
            //    //try içerisinde hata alındığında carch çalışacaktır.
            //}


            try
            {
                //hata alınabilecek komular yazılır.
                Console.WriteLine("Lütfen bir sayı giriniz");
                int Sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Sayi + " girdiniz.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata alındı. Lütfen sayısal bir ifade giriniz.");
            }


            try
            {
                //hata alınabilecek komular yazılır.
                Console.WriteLine("Lütfen bir sayı giriniz");
                int Sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Sayi + " girdiniz.");
            }
            catch (Exception ex) when(ex.Source=="msColorlib")
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            Console.ReadLine();
        }
    }
}
