using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    class Aplis : Geometriskafigura
    {
        public double Radiuss;
        public Aplis(double radiuss)
        {
            this.Radiuss = radiuss;
        }
        public void laukums()
        {
            double laukums = Math.PI * Radiuss * Radiuss;
            Console.WriteLine("Laukums = " + laukums);
        }

        public double perimetrs()
        {
            double perimetrs = Math.PI * Radiuss * Radiuss;

            return perimetrs;
        }

    }
}
