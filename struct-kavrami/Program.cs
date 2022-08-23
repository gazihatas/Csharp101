using System;

namespace struct_kavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Class larda ilk değer atanmasa bile nesne yapısı taradından ilk değer null olarak atanır
             * fakat
             * struct yapısında değer atanması lazım
             * 16byte a kadar olan verileriniz için struct kullanın eğer 16 byte dan buyukse veriniz nesne yapısını kullanın
             * küçük verilerle çalışacaksanız nesne tanımlamadan hızlıca işlerinizi halledebilirsiniz
             */

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı :{0}",dikdortgen.AlanHesapla());

            //struct new ile oluşturulmadan kullanılabilir.
            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(3, 4);
            //dikdortgen_struct.KisaKenar = 3;
            //dikdortgen_struct.UzunKenar = 4;

            Console.WriteLine("Struct Alan Hesabı :{0}",dikdortgen_struct.AlanHesapla());

        }

        class Dikdortgen
        {
            public int KisaKenar;
            public int UzunKenar;

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }
        }

        struct Dikdortgen_Struct
        {
            public int KisaKenar;
            public int UzunKenar;

            public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
            {
                KisaKenar = kisaKenar;
                UzunKenar = uzunKenar;
            }

            public long AlanHesapla()
            {
                return this.KisaKenar * this.UzunKenar;
            }
        }
    }
}
