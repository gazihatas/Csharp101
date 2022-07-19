using System;

namespace PASCAL_TRIANGLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen üçgenin kaç satır içereceğini giriniz: ");
            int satir = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < satir; i++)
            {
                int c = 1;
                for (int e = 0; e < satir - i; e++)
                {
                    Console.Write("   ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("    {0} ", c);
                    c = c * (i - x) / (x + 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
