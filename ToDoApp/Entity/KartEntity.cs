using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Entity
{
    public class KartEntity
    {
        private string baslik;
        private string icerik;
        private string kartSahibi;
        private string boyutlar;
        private int durum = 0;

        public string Baslik { get => baslik; set => baslik = value; }
        public string Icerik { get => icerik; set => icerik = value; }
        public string KartSahibi { get => kartSahibi; set => kartSahibi = value; }
        public string Boyutlar { get => boyutlar; set => boyutlar = value; }
        public int Durum { get => durum; set => durum = value; }
    }
}
