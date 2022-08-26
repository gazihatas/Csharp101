using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entity;
using ToDoApp.Enum;

namespace ToDoApp
{
    public class BoardManager : IBoardService 
    {
        
        KisiManager kisiler = new KisiManager();
        KartManager kartlar = new KartManager();
        

        public void varsayilanKisi()
        {
            kisiler.Ekle("1", "Gazi", "Hatas");

        }

        public void varsayilanKart()
        {
            kartlar.Ekle("Ders", "Todo Tamamlanacak", "1", "2");
        }
        public void kartListeleme()
        {

            Console.WriteLine("DONE Line");
            Console.WriteLine("***********************");

            List<KartEntity> list = kartlar.Liste();
            Console.WriteLine("Kartları Görüntüleme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("TODO Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum == 0)
                {
                    Console.WriteLine("Başlık =  {0}", item.Baslik);
                    Console.WriteLine("İçerik  = {0}", item.Icerik);
                    Console.WriteLine("Kart Sahibi = {0}",  kisiler.Ara(item.KartSahibi));
                    Console.WriteLine("kart boyutlarutu = {0}", (Boyut)int.Parse(item.Boyutlar));
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum == 1)
                {
                    Console.WriteLine("Başlık =  {0}", item.Baslik);
                    Console.WriteLine("İçerik  = {0}", item.Icerik);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi);
                    Console.WriteLine("kart Büyüklüğü = {0}", item.Boyutlar);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" DONE Line");
            Console.WriteLine("*******************************************");
            foreach (var item in list)
            {
                if (item.Durum == 2)
                {
                    Console.WriteLine("Başlık =  {0}", item.Baslik);
                    Console.WriteLine("İçerik  = {0}", item.Icerik);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi);
                    Console.WriteLine("kart Büyüklüğü = {0}", item.Boyutlar);
                }
            }

        }

        public void kartEkle()
        {
            #region KART EKLE

            Console.WriteLine("Card Ekleme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Başlık Giriniz                                       :");
            string baslik = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                       :");
            string icerik = Console.ReadLine();
            idGirisAlanı:
            Console.WriteLine("Kart Sahibinin İD'sini Giriniz");
            string id = Console.ReadLine();
            if (!kisiler.IdKontrol(id))
            {
                Console.WriteLine("Geçersiz id girdiniz.");
                goto idGirisAlanı;
            }
            kartBuyukluguGirisAlanı:
            Console.WriteLine("boyutları Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)      :");
            string boyutlar = Console.ReadLine();
            if (int.Parse(boyutlar) < 1 || int.Parse(boyutlar) > 5)
            {
                Console.WriteLine("yanlış bir boyut değeri girdiğiniz 1-5 arasında seçim yapınız.");
                goto kartBuyukluguGirisAlanı;
            }
            kartlar.Ekle(baslik, icerik, id, boyutlar);
            Console.WriteLine("İşlem Başarıyla Gerçekleşti");

            #endregion
        }

        public void kartSil()
        {
            List<KartEntity> list = new List<KartEntity>();
            Console.WriteLine("Kartları Silme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen silmek istediğiniz kart başlığını yazınız:");
            String veri = Console.ReadLine();
            list = kartlar.Bul(veri, "", "", "");
            if (list.Count <= 0)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Tekrar Denemek İçin (1)");
                Console.WriteLine("İşlemi İptal etmek için (2)");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == 1)
                {
                    kartSil();
                }
                if (sayi == 2)
                {

                }
            }
            else
            {
                Console.WriteLine("{0} kart ı silmek istiyor musunuz Y/N", list[0].Baslik);
                string YN = Console.ReadLine();
                if (YN == "Y")
                {
                    kartlar.Sil(list[0]);
                    Console.WriteLine("İşlem Başarıyla Gerçekleşti");
                }
                else
                {
                    Console.WriteLine("İşlem Başarıyla İptal Edildi");
                }
            }
        }

        public void kartTasi()
        {
            List<KartEntity> list = new List<KartEntity>();
            Console.WriteLine("Kart Taşıma Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Taşımak istediğiniz kartın kart başlığını giriniz");
            string veri = Console.ReadLine();
            list = kartlar.Bul(veri, "", "", "");
            if (list.Count <= 0)
            {
                Console.WriteLine("Aradığınız Card Bulunamadı");
                Console.WriteLine("Tekrar Denemek İçin (1)");
                Console.WriteLine("İşlemi İptal etmek için (2)");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == 1)
                {
                    kartTasi();
                }
                if (sayi == 2)
                {

                }
            }
            else
            {
                Console.WriteLine("Bulunan kart bilgiler");
                Console.WriteLine("*******************************************");
                foreach (var item in list)
                {
                    Console.WriteLine("Başlık =  {0}", item.Baslik);
                    Console.WriteLine("İçerik  = {0}", item.Icerik);
                    Console.WriteLine("Kart Sahibi = {0}", item.KartSahibi);
                    Console.WriteLine("kart Büyüklüğü = {0}", item.Boyutlar);
                    Console.WriteLine("Durum = {0}", item.Durum);
                    Console.WriteLine("****** ****** ****** ******");
                    l:
                    Console.WriteLine("Lütfen taşımak istediğiniz Durum'u seçiniz");
                    Console.WriteLine("(0) TODO");
                    Console.WriteLine("(1) IN PROGRESS");
                    Console.WriteLine("(2) DONE");

                    int sayi = int.Parse(Console.ReadLine());
                    if (sayi < 0 || sayi > 2)
                    {
                        Console.WriteLine("Yanlış bir Büyüklük seçtiniz");
                        goto l;
                    }
                    item.Durum = sayi;
                }
            }
        }

        
    }
}
