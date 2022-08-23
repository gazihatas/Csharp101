using System;

namespace Inheritance
{
     class Program
    {
        static void Main(string[] args)
        {
            Bitkiler.TohumluBitkiler tohumluBitki = new Bitkiler.TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("**************");

            Kuslar martı = new Kuslar();
            martı.Ucmak();


        }
    }
}
