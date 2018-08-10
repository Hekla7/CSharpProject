using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Auto
    {
        // auto ipashiba
        public String Krasa;
        // auto ipashiba - max atrums
        public int MaxAtrums;
        public void Braukt()
        {
            Console.WriteLine(" Auto brauc! MaxAtrums = " + MaxAtrums);
        }

        public void KrasasNoteiksana()
        {
            Console.WriteLine("Auto ir " + Krasa + " krasa!");
        }

        public static void BrauktStatic( int maxAtrums)
        {
            Console.WriteLine(" mAX atrums ir " + maxAtrums);
        }

    }
}
