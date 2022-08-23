using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    internal class Civic :IOtomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Marka HangiMarkanınAraci()
        {
            return Marka.Honda;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
