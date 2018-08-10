using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    class Neveiksmigais13
    {
        public static void Neveiksmigais()
        {
            List<int> skaitlji = new List<int>();
            int summa = 0;
            while (true)
            {
                Console.Write(" Ievadi skaitli vai 13, lai partrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
               
                if (skaitlis == 13)
                {
                   break;
                }
                skaitlji.Add(skaitlis);
               
            }
            foreach (int skaitit in skaitlji)
            {
                summa += skaitit;
            }
            Console.Write("--> summa " + summa);
        }
    }
}
