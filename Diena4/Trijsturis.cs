using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Trijsturis
    {
        public int mala1;
        public int mala2;
        public int mala3;
        public void perimetrs()
        {
            int perimetrs = mala1 + mala2 + mala3;
            Console.WriteLine("perimetrs" + perimetrs);
        }
        public void laukums()
        {
            double p = (double)(mala1 + mala2 + mala3) / 2;
            double laukums = Math.Sqrt(p
            * (p - mala1
            * (p - mala2)
            * (p - mala3)));
                
                
        }
    }
}
