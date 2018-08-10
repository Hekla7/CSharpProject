using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplis aplis = new Aplis(5);
            Kvadrats kvadrats = new Kvadrats(10);
            Taisnsturis taisnsturis = new Taisnsturis(5,10);
            VeiktAprekinus("Kvadrats", kvadrats);
            VeiktAprekinus("Aplis", aplis);
            VeiktAprekinus("Taisnsturis", taisnsturis);
            Console.ReadLine();
        }
        static void VeiktAprekinus(string nosaukums, Geometriskafigura figura)
        {
            Console.WriteLine(nosaukums);
            //izvada rezultatu
            figura.laukums();

            // sanjem aprekinato rezultatu un tad izvada
            // jo metode atgriezh double
            double perimetrs = figura.perimetrs();
            Console.WriteLine("Perimetrs = " + perimetrs);
        }

            static void Piemers(string[] args)
        {
            Auto auto = new Auto();
            Lidmashina lidmashina = new Lidmashina();
            Parvietot(auto);
            Parvietot(lidmashina);

            Console.ReadLine();
        }
        static void Parvietot(Transportlidzeklis tr)
        {
            tr.parvietoties();
        }
    }
}
