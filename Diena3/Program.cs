using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevumi.Uzdevums1();
            //Uzdevumi.Uzdevums2();
            // Uzdevumi.Uzdevums3();
            // Uzdevumi.Uzdevums4();
            // Uzdevumi.Uzdevums5();
           // Uzdevumi.Uzdevums6();
            //Uzdevumi.Uzdevums7();
            Uzdevumi.Uzdevums8();
            Console.ReadLine();
        }
        static void Piemers()
        {
            string mervieniba = "C";
            switch (mervieniba)
            {
                case "C":
                    Console.Write("Ievaditi celsiji");
                    break;
                case "F":
                    Console.Write("Ievaditi farenheiti");
                    break;
                case "K":
                    Console.Write("Ievaditi Kelvini");
                    break;
                case "Z":
                case "A":
                    Console.Write("Ievadits A vai Z");
                    break;
                default:
                    Console.Write("Nezinama mervieniba");
                    break;
            }
        }
    }
}
