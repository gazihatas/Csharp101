using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public interface IKisiService
    {
        void Ekle(string id, string isim, string soyisim);
        string Ara(string sayi);
        bool IdKontrol(string sayi);
    }
}
