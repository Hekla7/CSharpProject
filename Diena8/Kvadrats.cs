using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    public class Kvadrats : Taisnsturis
    {
        public double MalasGarums;
        public Kvadrats(double mala)
            : base(mala, mala) {
            // base() --> izsaukts 'virsklases' konstruktors

            MalasGarums = mala;
        }
        public void laukums()
        {
           double laukums = MalasGarums * MalasGarums;
            Console.WriteLine("Laukums = " + laukums);
        }

        public double perimetrs()
        {
            double perimetrs = MalasGarums * 4;
            return perimetrs;
        }
    }
}
