using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class BoardManager : IBoardService
    {
        public void boardListeleme()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("***********************");
            Console.WriteLine("Başlık      :");
            Console.WriteLine("İçerik      :");
            Console.WriteLine("Atanan Kişi :");
            Console.WriteLine("Büyüklük    :");
            Console.WriteLine("-");
            Console.WriteLine("Başlık      :");
            Console.WriteLine("İçerik      :");
            Console.WriteLine("Atanan Kişi :");
            Console.WriteLine("Büyüklük    :");
            Console.WriteLine("\n \n \n");

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("***********************");
            Console.WriteLine("Başlık      :");
            Console.WriteLine("İçerik      :");
            Console.WriteLine("Atanan Kişi :");
            Console.WriteLine("Büyüklük    :");
            Console.WriteLine("-");
            Console.WriteLine("Başlık      :");
            Console.WriteLine("İçerik      :");
            Console.WriteLine("Atanan Kişi :");
            Console.WriteLine("Büyüklük    :");
            Console.WriteLine("\n \n \n");



            Console.WriteLine("DONE Line");
            Console.WriteLine("***********************");



        }

        public void kartEkle()
        {
            #region KART EKLE

            Console.WriteLine("Başlık Giriniz                                  :");
            Console.WriteLine("İçerik Giriniz                                  :");
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            Console.WriteLine("Kişi Seçiniz                                    :");

            #endregion
        }

        public void kartGuncelle()
        {
            
        }

        public void kartSil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");

            //Kart bulunamaz ise
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine(" * Yeniden denemek için : (2)");
        }

        public void kartTasi()
        {
            
        }
    }
}
