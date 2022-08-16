using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.collection.generic
            //key => value seklinde çalısır
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18,"Deniz Arda");
            kullanıcılar.Add(20,"Özcan Coşar");


            //Dizinin elemanlarına erişim
            Console.WriteLine("**** Elemanlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);


            //Count
            Console.WriteLine("**** Count *****");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("**** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Gazi Hataş"));

            //Remove
            Console.WriteLine("**** Remove *****");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);

            //Keys - Values => key ve value larını ayrı elde etme
            Console.WriteLine("**** Keys *****");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);

            //Values
            Console.WriteLine("**** Values *****");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);

        }
    }
}
