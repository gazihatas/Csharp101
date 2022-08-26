using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Entity
{
    public class KisiEntity
    {
        private string id;
        private string isim;
        private string soyisim;

        public string Id { get => id; set => id = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
    }
}
