using System;

namespace diziler2_array_sinifi_metotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Sıralı Dizi *****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
               Console.WriteLine(sayi);

            //Clear : Dizi içerisinde verdiğiniz indeksten başlayarak verdiğiniz eleman sayısı kadar değeri sıfırlar. Direk gidip dizinin o elamanına sıfır atar.
            Console.WriteLine("***** Array Clear *****");
            //sayiDizisi elemanlarını kullanarak 2.index'ten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse : tersine çevirme işlemi. Verdiğiniz diziyi ortadan itibaren aynalıyormuş gibi yer değiştiriyor.
            //ilk değişkeni ilk elemanı son eleman yapar. son elemanı ilk eleman yapar.
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf : Verdiğiniz dizi üzerinde verdiğiniz elemanın eğer içerisinde varsa indexini döner 
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize : yeniden boyutlandırma yapar.
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);//dizinin boyutunu 9 yaptı
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}
