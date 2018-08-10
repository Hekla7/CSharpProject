using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Aplis
    {
        public int Radiuss;
        public void laukums() {
            double pi = Math.PI;
            double area = pi * (Radiuss * Radiuss);
            Console.WriteLine("Laukums ir " + area);
        }
        public void perimetrs()
        {
            double perim = 2 * Math.PI * Radiuss;
            Console.WriteLine("Perimetrs ir " + perim);
        }
    }
}
