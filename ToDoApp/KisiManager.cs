using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entity;

namespace ToDoApp
{
    public class KisiManager : IKisiService
    {
        private List<KisiEntity> kisiler;

        public KisiManager()
        {
            kisiler = new List<KisiEntity>();
        }

        public string Ara(string sayi)
        {
            string sonuc = "";

            foreach (var kisi in kisiler)
            {
                if (kisi.Id == sayi)
                {
                    sonuc = kisi.Isim + " " + kisi.Soyisim;
                }
            }

            return sonuc;
        }

        
        public void Ekle(string id, string isim, string soyisim)
        {
            KisiEntity kisiModel = new KisiEntity();
            kisiModel.Id = id;
            kisiModel.Isim = isim;
            kisiModel.Soyisim = soyisim;
            kisiler.Add(kisiModel);
        }


        public bool IdKontrol(string sayi)
        {
            bool sonuc = false;

            foreach (var kisi in kisiler)
            {
                if (kisi.Id == sayi)
                {
                    sonuc = true;
                }
            }

            return sonuc;
        }

    }
}
