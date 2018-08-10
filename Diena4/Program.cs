using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvadrats kv1 = new Kvadrats();
            kv1.KrasasNosaukums = "zalja";
            kv1.malasgarums = 5;
            kv1.laukums();
            kv1.perimetrs();
            kv1.krasa();

            Console.ReadLine();
            Aplis aplis = new Aplis();
            aplis.laukums();

        }
            static void Piemers(string[] args)
            {
                Auto auto1 = new Auto();
                auto1.MaxAtrums = 200;
                auto1.Krasa = "melnaa";
                auto1.Braukt();
                auto1.KrasasNoteiksana();

                Auto auto2 = new Auto();
                auto2.MaxAtrums = 150;
                auto2.Krasa = "sarkanaa";
                auto2.Braukt();
                auto2.KrasasNoteiksana();


                Console.ReadLine();
            }
        }
    }
}
