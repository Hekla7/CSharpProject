using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dilstosha_virkne.DilstoshaVirkne();
            //Dilstosha_virkne.Modinatajs.Modinat();
            //AtrumaParkapejs.AtrumaSkaitishana();
            //Neveiksmigais13.Neveiksmigais();
            //FizzBuzz.FizzorBuzz();
            Karatavs k = new Karatavs();
            k.StartNewGame();
            while (!k.VaiIrAtminets() &&k.VaiIrMeginajumi())
            {
                Console.Write("Ievadi burtu ");
                string ievade = Console.ReadLine();
                k.MinetBurtu(Convert.ToChar(ievade));
            }
            if (k.VaiIrMeginajumi())
            {
                Console.WriteLine("Vards ir atminets!");
            }
            else
            {
                Console.WriteLine("Beidzas meginajumi!");
                Console.WriteLine("Vards bija" + k.Vards());
            }
 
        }
    }
}
