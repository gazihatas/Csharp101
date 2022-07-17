using System;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            metotlar slında fonksiyonlardır. OOP yapısından sonra metot adını aldılar.
            Bir programı parçalamak için kullanırız.
            kod tekrarını önler ve okunabilirliği artırır.
            Metotlar tekbaşlarına çağıralamaz ve yazılamazlar. Metotlar bir class'ın içinde yazılmalıdır.
            Metot aynı class içinde yazıldıysa direk erişim sağlayabilirsiniz fakat farklı bir class ta ise nesnesini oluşturup çağırılır.
            * 
            */

            /*
             * Erisim Belirteci Bu metodun nereden erişilebilir olduğu söylenmektedir. 
             * Bu metodun nereden erişilebildeğini söylemiş oluyoruz.
             * Eğer bir metodu 
             * public => heryerden erişilebilir
             * private => Mevcut tanımlandığı class üzerinden erişilebilir.
             * 
             * 
             */

            /*
             * 
             * geri_donustipi => Bu metot bir iş yaptıktan sonra geriye bir şey dönecekmi, çağırıldığı yerden birşeye ihtiyac duyuluyormu
             * her türlü veri tipini dönebilirsiniz
             * Her bir metodun bir geri dönüşü olmak zorunda değildir. 
             * geri dönüşü olmayan metotları tanımlamak için void keyword ü kullanılır.
             * geri_donustipi metotun imzasını tasır mutlaka yazılmalıdır bişey dönmeyecekseniz void yazmalısınız.
             */



            //erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{
            ////komutlar;
            ///// return;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            //ben bu fonksiyona a ve b nin değerlerini değilde bellekteki değerlerini belirtmiş oluruz.
            int sonuc2 = ornek.ArttırVeTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));


        }

        //iki sayıy toplayan metot
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }

    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
