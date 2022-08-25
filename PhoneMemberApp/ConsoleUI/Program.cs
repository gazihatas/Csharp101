using System;
using System.ComponentModel.Design;
using PhoneMemberApp.Business;
using PhoneMemberApp.DataAccess;
using PhoneMemberApp.Entities;

namespace PhoneMemberApp.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                menuu:
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Varolan Numarayı Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                int secim = int.Parse(Console.ReadLine());

                if (secim==1 && !secim.Equals(typeof(int)))
                {
                    #region NumaraEkle

                    PersonManager personManager = new PersonManager(new InMemoryPersonDal());
                    InMemoryPersonDal personalController = new InMemoryPersonDal();

                    Console.WriteLine("Lütfen isim giriniz                  :");
                    string consoleName = Console.ReadLine();
                    Console.WriteLine("Lütfen soyisim giriniz               :");
                    string consoleSurname = Console.ReadLine();
                    Console.WriteLine("Lütfen telefon numarası girniz       :");
                    int consolePhoneNumber = int.Parse(Console.ReadLine());

                    
                    int idSayac = 5;

                    Person persona = new Person() { Id = idSayac++, Name = consoleName, PhoneNumber = consolePhoneNumber, Surname = consoleSurname };

                    personalController.Add(persona);
                    Console.WriteLine("Kayıt başarılı");
                    Console.WriteLine("MENU'ye dönmek için 1");
                    Console.WriteLine("ÇIKIŞ için 0");
                    
                    foreach (var aperson in personalController.GetAll())
                    {
                        Console.WriteLine(aperson.Name);
                        Console.WriteLine(aperson.Surname);
                        Console.WriteLine(aperson.PhoneNumber);
                    }

                    #endregion
                }
                else if (secim == 2 && !secim.Equals(typeof(int)))
                {
                    
                }
                else if (secim == 3 && !secim.Equals(typeof(int)))
                {
                    
                }
                else if (secim == 4 && !secim.Equals(typeof(int)))
                {
                    PersonManager personManager = new PersonManager(new InMemoryPersonDal());
                    foreach (var person in personManager.GetAll())
                    {
                        Console.WriteLine(person.Name);
                        Console.WriteLine(person.Surname);
                        Console.WriteLine(person.PhoneNumber);
                    }
                }
                else if (secim == 2 && !secim.Equals(typeof(int)))
                {
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen geçerli seçim değeri girin!");
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^s");
                    goto menuu;
                }


            }
            catch
            {
                Console.WriteLine("Lütfen seçim için sayı tipinde değer giriniz");
            }

          
            

         


        }
    }

    
}
