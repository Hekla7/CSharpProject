using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Taisnsturis
    {
        int mala1;
        int mala2;
        public void perimetrs()
        {
            int perimetrs = (mala1 + mala2) * 2;
            Console.WriteLine("Perimetrs " + perimetrs);
        }

        public void laukums()
        {
            Console.WriteLine("Laukums = " + mala1 * mala2);
        }

    }
}
