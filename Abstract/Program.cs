using System;

namespace InterfaceOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());


        }
    }
}
