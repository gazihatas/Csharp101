using System;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoardManager boardManager = new BoardManager();
            boardManager.varsayilanKisi();
            boardManager.varsayilanKart();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");


            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    boardManager.kartListeleme();
                    break;
                case 2:
                    boardManager.kartEkle();
                    break;
                case 3:
                    boardManager.kartSil();
                    break;
                case 4:
                    boardManager.kartTasi();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    //Menu.MenuUI();
                    break;


            }

        }
    }
}
