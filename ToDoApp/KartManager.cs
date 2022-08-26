using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entity;

namespace ToDoApp
{
    public class KartManager : IKartService
    {
        List<KartEntity> kartlarListesi;

        public KartManager()
        {
            kartlarListesi = new List<KartEntity>();
        }

        public List<KartEntity> Liste()
        {
            return kartlarListesi;
        }

        public void Ekle(string baslik, string icerik, string kartSahibi, string boyutlar)
        {
            KartEntity kartModel = new KartEntity();
            kartModel.Baslik = baslik;
            kartModel.Icerik = icerik;
            kartModel.KartSahibi = kartSahibi;
            kartModel.Boyutlar = boyutlar;
            kartlarListesi.Add(kartModel);
        }
        

        public void Sil(KartEntity kartModel)
        {
            kartlarListesi.Remove(kartModel);
        }

      

        public List<KartEntity> Bul(string baslik, string icerik, string kartSahibi, string boyutlar)
        {
            List<KartEntity> sonuc = new List<KartEntity>();

            foreach (var kart in kartlarListesi)
            {
                if (kart.Baslik == baslik || kart.Icerik == icerik || kart.KartSahibi == kartSahibi || kart.Boyutlar == boyutlar)
                {
                    sonuc.Add(kart);
                }
            }
            return sonuc;
        }
    }
}
