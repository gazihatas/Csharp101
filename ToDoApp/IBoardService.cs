using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public interface IBoardService
    {
        void varsayilanKisi();
        void varsayilanKart();
        void kartEkle();
        void kartSil();
        void kartTasi();
        void kartListeleme();
    }
}
