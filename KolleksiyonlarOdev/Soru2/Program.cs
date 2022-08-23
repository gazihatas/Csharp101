using System;
using System.Linq;

namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n = 20;
            string? entry;
            int[] arr = new int[n];

            Console.WriteLine("Please enter positive number");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter {0}. number", i + 1);
                entry = Console.ReadLine();
                if (int.TryParse(entry, out num))
                {
                    arr[i] = num;
                }
                else
                {
                    Console.WriteLine("The num can not be non numeric. Try again..");
                    i--;
                }
            }

            Array.Sort(arr);
            int[] max_3 = { arr[n - 1], arr[n - 2], arr[n - 3] };
            int[] min_3 = { arr[0], arr[1], arr[2] };

            Console.WriteLine("Max 3 Average: " + max_3.Average());
            Console.WriteLine("Min 3 Average: " + min_3.Average());
            Console.WriteLine("Max 3 Average + Min 3 Average: " + (max_3.Average() + min_3.Average()));
        }
    }
}
