 using System;

namespace hata_yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    try
        //    {
        //        //Hataya neden olabilecek kod yazılır.
        //        //Hata alması muhtemel ve Konrol etmek istediğiniz ve güvence altına almak istediğiniz kod bloğu girilir.
        //        Console.WriteLine("Bir sayı giriniz:");
        //        int sayi = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
        //    }
        //    catch (Exception ex)
        //    {
        //        //hata fırlattığında hata burada gösterilir
        //        //hatayı yakaladığınızda ne yapmak istiyorsanız onu yapıyorsunuz.
        //        Console.WriteLine("Hata: " + ex.Message.ToString());
        //    }
            //finally
            //{
            //    //finally bloğu zorunlu değildir.
            //    //Koşuldan bağımsız çalışmasını istediğimiz kod bloğudur.
            //    Console.Write("İşlem Tamamlandı.");
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex) 
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer giridiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
           
        }
    }
}
