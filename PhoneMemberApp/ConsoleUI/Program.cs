using System;
using PhoneMemberApp.Business;
using PhoneMemberApp.DataAccess;
using PhoneMemberApp.Entities;

namespace PhoneMemberApp.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            //Console.WriteLine("*******************************************");
            //Console.WriteLine("(1) Yeni Numara Kaydetmek");
            //Console.WriteLine("(2) Varolan Numarayı Silmek");
            //Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            //Console.WriteLine("(4) Varolan Numarayı Listelemek");
            //Console.WriteLine("(5) Rehberde Arama Yapmak");

            PersonManager personManager = new PersonManager(new InMemoryPersonDal());
            InMemoryPersonDal personalController = new InMemoryPersonDal();

            //foreach (var person in personManager.GetAll())
            //{
            //    Console.WriteLine(person.Name);
            //    Console.WriteLine(person.Surname);
            //    Console.WriteLine(person.PhoneNumber);
            //}


            Console.WriteLine("İSİM");
            string isim = Console.ReadLine();


            Console.WriteLine("SOYİSİM");
            string soyIsim = Console.ReadLine();

            Console.WriteLine("numara gir");
            int numara = int.Parse(Console.ReadLine());

            Person persona = new Person();
            persona.Id = 6;
            persona.Name = isim;
            persona.Surname = soyIsim;
            persona.PhoneNumber = numara;


            personalController.Add(persona);
            foreach (var aperson in personalController.GetAll())
            {
                Console.WriteLine(aperson.Name); 
                Console.WriteLine(aperson.Surname);
                Console.WriteLine(aperson.PhoneNumber);
            }
        }
    }
}
