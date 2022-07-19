using System;

namespace Odev1_Algoritma_Sorunlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
                Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
                Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            */
            Console.WriteLine("Lütfen bir pozitif sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(n + "adet pozitif sayı giriniz.");
            int girilenPozitifSayi;
            for (int i = 1; i <=n; i++)
            {
                girilenPozitifSayi = Convert.ToInt32(Console.ReadLine());
                
                if (girilenPozitifSayi % 2 == 0)
                    Console.WriteLine("Girmiş olduğunuz çift sayılar" + girilenPozitifSayi);
                
            }

            // int[] nSayi = new int[n];


            /*
              2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
                Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
                Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
             */
            /*
              3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
                Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
                Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            */

            /*
              4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
                Cümledeki toplam kelime ve harf sayısını console'a yazdırın. 
           */
        }
    }
}