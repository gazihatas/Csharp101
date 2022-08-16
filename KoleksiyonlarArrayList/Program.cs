using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KoleksiyonlarArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            liste.Add("Ayşer");
            liste.Add(2);
            liste.Add(true);
            liste.Add("A");

            //içerisinde verilere eişim
            //Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
             Console.WriteLine(item);
            }

            //AdRange
            Console.WriteLine("***** Add Range *****");
            //string[] renkler = {"kırmızı", "sarı","yeşi"};
            List<int> sayilar = new List<int>() {1,8,3,7,9,92,5};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach(var item in liste)
                Console.WriteLine(item);

            //Short
            Console.WriteLine("***** Short *****");
            liste.Sort();
            foreach (var item in liste )
                Console.WriteLine(item);

            //Binary Search
            Console.WriteLine("***** Binary Srach ******");
            Console.WriteLine(liste.BinarySearch(9));


            //Reverse
            Console.WriteLine("****** Reverse ******");
            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("***** Clear ******");
                liste.Clear();

                foreach (var item in liste)
                {
                    Console.WriteLine(item);   
                }
        }
    }
}
