using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    public class Corolla : IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Marka HangiMarkanınAraci()
        {
            return Marka.Toyota;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}
