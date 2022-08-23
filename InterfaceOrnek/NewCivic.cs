using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    public class NewCivic :Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public override Renk StandarRenkNe()
        {
            return Renk.Gri;
        }
    }
}
