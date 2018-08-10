using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena1_uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //VardaIzvade();
            //Skaitlusumma();
            //Skaitlustarpiba();
            //Skaitlureizinajums();
            Skaitludalijums();
            GraduParversana();

        }
        static void Skaitlusumma()
        {
            //pieprasa ievadit 1.skaitli
            Console.Write("Ievadi 1 skaitli: ");
            int skaitlis_1 = Convert.ToInt32(Console.ReadLine());

            //pieprasa ievadit 2.skaitli
            Console.Write("Ievadi 2 skaitli: ");
            int skaitlis_2 = Convert.ToInt32(Console.ReadLine());

            //izvada skaitlu summu
            int summa = skaitlis_1 + skaitlis_2;
            Console.Write("Summa ir " + summa);

            // lai console logs paliek atverts
            Console.ReadLine();
        }

        static void Skaitlustarpiba()

        {
            //pieprasa ievadit 1.skaitli
            Console.Write("Ievadi 1 skaitli: ");
            int skaitlis_1 = Convert.ToInt32(Console.ReadLine());

            //pieprasa ievadit 2.skaitli
            Console.Write("Ievadi 2 skaitli: ");
            int skaitlis_2 = Convert.ToInt32(Console.ReadLine());

            //izvada skaitlu starpibu
            int starpiba = skaitlis_1 - skaitlis_2;
            Console.Write("Starpiba ir " + starpiba);

            // lai console logs paliek atverts
            Console.ReadLine();

        }

        static void Skaitlureizinajums()

        {
            //pieprasa ievadit 1.skaitli
            Console.Write("Ievadi 1 skaitli: ");
            int skaitlis_1 = Convert.ToInt32(Console.ReadLine());

            //pieprasa ievadit 2.skaitli
            Console.Write("Ievadi 2 skaitli: ");
            int skaitlis_2 = Convert.ToInt32(Console.ReadLine());

            //izvada skaitlu reizinajumu
            int reizinajums = skaitlis_1 * skaitlis_2;
            Console.Write("Starpiba ir " + reizinajums);

            // lai console logs paliek atverts
            Console.ReadLine();

        }

        static void Skaitludalijums()

        {
            //pieprasa ievadit 1.skaitli
            Console.Write("Ievadi 1 skaitli: ");
            int skaitlis_1 = Convert.ToInt32(Console.ReadLine());

            //pieprasa ievadit 2.skaitli
            Console.Write("Ievadi 2 skaitli: ");
            int skaitlis_2 = Convert.ToInt32(Console.ReadLine());

            //izvada skaitlu dalijumu
            int reizinajums = skaitlis_1 / skaitlis_2;
            Console.Write("Starpiba ir " + reizinajums);

            // lai console logs paliek atverts
            Console.ReadLine();

        }



        static void GraduParversana()
        {
            Console.Write("Ievadi gradus pec Celsija: ");
            int celsijs = Convert.ToInt32(Console.ReadLine());

            int kelvini = celsijs + 273;
            double farenheiti = celsijs * 1.8 + 32;
            // float farenheiti = celsijs * 1.8f + 32; var gan ar double, gan float - bet floatam nesaprot 1.8, tad japieliek f

            Console.WriteLine("Kelvini = " + kelvini);
            Console.WriteLine("Farenheiti = " + farenheiti);

            Console.ReadLine();
        }

        static void VardaIzvade()
        {
            Console.Write("Ievadi vardu: ");
            string vards = Console.ReadLine(); // ievadita teksta izvade un izvadis tikai tad, ja lietotajs nospiedis enter

            // uzvarda ievade
            Console.Write("Ievadi uzvardu: ");
            string uzvards = Console.ReadLine();

            // vecums
            Console.Write("Ievadi vecumu: ");
            int vecums = Convert.ToInt32(Console.ReadLine()); //ReadLine vienmer atgrieћ stringu Console, lai konvertetu uz integer, liekam konvertoru.
            //ToIn32 -> 32 tie ir biti. Ja bus long tad aiznems vairak.
            // vispirms izpildis ReadLine'(ieksejaa funkcija), tad iet uz arejo funkciju
            //var ari љadi pierkastit

            // string vecumsStrings = Console.ReadLine();
            //int vecums = Convert.ToInt32(vecumsStrings);

            // teksta izvade
            //Console.WriteLine("Tevi sauc " + vards + " " + uzvards); // љo izvada viena rinda un vecumu nakoљaja
            Console.Write("Tevi sauc " + vards + " " + uzvards); // љo un vecumu izvada viena rinda
            Console.Write(" un tev ir " + vecums + " gadi!");

            // lai console logs paliek atverts
            Console.ReadLine();
        }
    }
}
