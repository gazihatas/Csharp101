using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    internal class NewCorolla :Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
    }
}
