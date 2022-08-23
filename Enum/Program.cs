﻿using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Enum lar default olarak 1'den başlar.
             */
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);

            int sicaklik = 32;

            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın b,raz daha ısınmasını bekleyelim");
            }
            else if (sicaklik >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if (sicaklik >=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hadi dışarıya çıkalım.");
            }
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSicak = 30
    }
}
