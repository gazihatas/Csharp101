using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*System.Collections namespace
             * 
             * Koleksiyonlar => Tek bir veri tipini değil birden fazla veri tipini kendi içersinde barındırabilen yapılar
             * 
             * ArrayLsit => ArraList ler bir koleksiyon tipidir.
             * birden fazla veri tipini aynı anda saklayabilirsin
             */

            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //içersinde verilere erişim
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange
            Console.WriteLine("****** Add Range ******");
            //string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int>() { 1, 8, 7, 3, 9, 92, 5 };

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("****** Sort ******");
            liste.Sort();

            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            //Binary Search

            Console.WriteLine("****** Binary Search ******");
            Console.WriteLine(liste.BinarySearch(9));


            //Reverse
            Console.WriteLine("****** Reverse ******");
            liste.Reverse();


            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
}
