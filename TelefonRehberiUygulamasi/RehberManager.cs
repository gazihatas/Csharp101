using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberiUygulamasi
{
    public class RehberManager : IRehberService
    {
        public static List<Kisiler> Kisiler = new List<Kisiler>();
        public RehberManager()
        {
            Kisiler.Add(new Kisiler() { Isim = "Gazi", Soyisim = "Hatas", Numara = "05558897814" });
            Kisiler.Add(new Kisiler() { Isim = "Ahmet", Soyisim = "Acar", Numara = "05879631247" });
            Kisiler.Add(new Kisiler() { Isim = "Ali", Soyisim = "Test", Numara = "07892584503" });
            Kisiler.Add(new Kisiler() { Isim = "Veli", Soyisim = "Demo", Numara = "05214752314" });
            Kisiler.Add(new Kisiler() { Isim = "Cenk", Soyisim = "Ass", Numara = "05714239401" });

        }
        public void numaraEkle()
        {
            Console.WriteLine("Lütfen isim giriniz                         :");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz                      :");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz             :");
            string numara = Console.ReadLine();

            Kisiler.Add(new Kisiler() { Isim = isim, Soyisim = soyisim, Numara = numara });

            Console.WriteLine("Kişi rehbere Kayıt edilmiştir");
            
        }

        public void numaraSil()
        {
            Console.Clear();
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string isim = Console.ReadLine();

            foreach (var kisi in Kisiler)
            {

                if (kisi.Isim == isim || kisi.Soyisim == isim)
                {
                    Console.WriteLine(kisi.Isim + "isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    char secimKontrol = char.Parse(Console.ReadLine());
                    if (secimKontrol == 'y' || secimKontrol == 'Y')
                    {
                        Kisiler.Remove(kisi);
                        Console.WriteLine(kisi.Isim + " Başarı ile silindi");
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız");
                        Console.ReadKey();
                        break;
                    }
                    else if (secimKontrol == 'n' || secimKontrol == 'N')
                    {
                        break;
                    }
                }
                else
                {
                    MenuSil:
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("*Yeniden denemek için      : (2)");
                    Console.WriteLine("*Çıkış için                : (3)");
                    var secim = Console.ReadLine();
                    if (secim =="1")
                    {
                        return;
                    }
                    else if (secim =="2")
                    {
                        numaraSil();
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir karakter girdiniz ");
                        goto MenuSil;
                        //Console.ReadKey();
                    }
                }
            }

        }


        public void numaraListele()
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var kisi in Kisiler)
            {
                Console.WriteLine($"İsim             : {kisi.Isim}");
                Console.WriteLine($"Soyisim          : {kisi.Soyisim}");
                Console.WriteLine($"Telefon Numarası : {kisi.Numara}");
                Console.WriteLine("*");
            }

            Console.WriteLine($"Rehberde {Kisiler.Count} kişi mevcuttur.Ana menüye dönmek için bir tuşa basınız.. ");
            Console.ReadKey();
        }
        public void numaraGuncelle()
        {
            List<Kisiler> Kisiler1 = new List<Kisiler>();
            Console.Clear();
            Console.WriteLine("Güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine();

            foreach (var kisi in Kisiler)
            {
                if (kisi.Isim == name || kisi.Soyisim == name)
                {

                    Console.WriteLine("İsim : " + kisi.Isim);
                    Console.WriteLine("Soyisim : " + kisi.Soyisim);
                    Console.WriteLine("Telefon Numarası : " + kisi.Numara);
                    Console.WriteLine();
                    Console.Write("Yeni isim gir : ");
                    string isim = Console.ReadLine();
                    Console.Write("Yeni soyisim gir : ");
                    string soyisim = Console.ReadLine();
                    Console.Write("Yeni numara gir : ");
                    string numara = Console.ReadLine();
                    Kisiler1.Add(new Kisiler() { Isim = isim, Soyisim = soyisim, Numara = numara });
                    Console.WriteLine("Başarı ile güncellendi");

                }
                else
                {
                    Kisiler1.Add(new Kisiler() { Isim = kisi.Isim, Soyisim = kisi.Soyisim, Numara = kisi.Numara });
                }


            }

            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                Kisiler.Clear();
                Kisiler = Kisiler1;
            }
            if (selection == 2)
            {
                numaraGuncelle();
            }

            Console.ReadKey();
        }

        public void numaraAra()
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisim arama yapmak için (1) :");
            Console.WriteLine("Telefon numarasına göre arama yapmak (2) :");
            char selection = char.Parse(Console.ReadLine());

            if (selection == '1')
            {

                Console.Clear();
                Console.Write("İsim veya soyisim giriniz : ");
                string isim = Console.ReadLine();
                foreach (var kisi in Kisiler)
                {
                    if (kisi.Isim == isim || kisi.Soyisim == isim)
                    {
                        Console.WriteLine("İsim : " + kisi.Isim);
                        Console.WriteLine("Soyisim : " + kisi.Soyisim);
                        Console.WriteLine("Telefon Numarası : " + kisi.Numara);
                        Console.WriteLine();
                        Console.ReadKey();

                    }
                }
                Console.WriteLine("Böyle bir kayıt bulunamadı");
                Console.ReadKey();

            }
            else if (selection == '2')
            {
                Console.Clear();
                Console.WriteLine("Telefon numarası giriniz.");
                string numara = Console.ReadLine();
                foreach (var kisi in Kisiler)
                {
                    if (kisi.Numara == numara)
                    {
                        Console.WriteLine("İsim : " + kisi.Isim);
                        Console.WriteLine("Soyisim : " + kisi.Soyisim);
                        Console.WriteLine("Telefon Numarası : " + kisi.Numara);
                        Console.WriteLine();
                        Console.ReadKey();

                    }
                }
                Console.WriteLine("Böyle bir kayıt bulunamadı");

            }
        }
       
    }
}
