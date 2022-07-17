﻿using System;

namespace karar_yapilari_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time>=6 && time<11)
                Console.WriteLine("Günaydın!");
            else if (time <= 18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("İyi Geceler");

            //Ternary
            string sonuc = time <= 18 ? "İyi Günler" : "İyi geceler";

            sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler?";
            Console.WriteLine(sonuc);
        }
    }
}
