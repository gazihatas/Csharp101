using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entity;

namespace ToDoApp
{
    public interface IKartService
    {
        void Ekle(string baslik, string iceril, string kartSahibi, string boyutlar);
        void Sil(KartEntity kart);
        public List<KartEntity> Bul(string baslik, string icerik, string kartSahibi, string boyutlar);
        List<KartEntity> Liste();
    }
}
