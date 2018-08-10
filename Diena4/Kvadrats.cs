using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    public class Kvadrats
    {
        public int malasgarums;
        public string KrasasNosaukums;

        public void laukums()
        {
            int laukums = malasgarums * malasgarums;
            Console.WriteLine("Laukums = " + laukums);
        }
             
        public void krasa() {
            Console.WriteLine("Krasa = " + KrasasNosaukums);
        }
        public void perimetrs() {
            Console.WriteLine("Perimetrs = " + malasgarums * 4);
        }

    
    }
}

    


