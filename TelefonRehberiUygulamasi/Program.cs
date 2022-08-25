using System;

namespace TelefonRehberiUygulamasi
{
    public class Program 
    {
        static void Main(string[] args)
        {
            RehberManager rehberManager = new RehberManager();
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

                if (secim == 1 && !secim.Equals(typeof(int)))
                {
                    rehberManager.numaraEkle();
                }
                else if (secim == 2 && !secim.Equals(typeof(int)))
                {
                    rehberManager.numaraSil();
                }
                else if (secim == 3 && !secim.Equals(typeof(int)))
                {
                    rehberManager.numaraGuncelle();
                }
                else if (secim == 4 && !secim.Equals(typeof(int)))
                {
                    rehberManager.numaraListele();
                }
                else if (secim == 5 && !secim.Equals(typeof(int)))
                {
                    rehberManager.numaraAra();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen geçerli seçim değeri girin!");
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                    goto menuu;
                }


            }
            catch
            {
                Console.WriteLine("Lütfen seçim için sayı tipinde değer giriniz");
            }
        }
    }

    public class Kisiler
    {
        private string isim;
        private string soyisim;
        private string numara;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Numara { get => numara; set => numara = value; }
    }

}
