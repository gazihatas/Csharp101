using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace AsalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("Asal sayı değildir");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {

            //kendisi ve  hariç tam böleni olmayan sayıdır.

            bool result = true;

            for (int i = 2; i<number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
