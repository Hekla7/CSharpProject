using System;
using System.Collections.Generic;
using System.Text;

namespace DzerienuAutomats
{
    class Automats
    {
        public double Summa;
        public Automats()
        {
            Summa = 0;
    }
        public void Iemaksat(double summa)
        {
            Summa += summa;
        }
        public void PirktDzerienu()
        {
           if (Summa < 0.8)
            {
                Console.WriteLine("Nepietiek lidzeklju!");
            }
            else
            {
                Summa -= 0.8;
                Console.WriteLine("Atlikums: " + Summa);
            }
        }
        public void IzdotAtlikumu()
        {
            Console.WriteLine("Tu sanjemi: " + Summa);
            Summa = 0;
        }
        public void Darbibas()
        {
            Console.WriteLine("Izvelies darbibu: ");
            Console.WriteLine("-Iemaksat (i) ");
            Console.WriteLine("-Pirkt (p) ");
            Console.WriteLine("-Izdot atlikumu (a) ");
            Console.WriteLine("-Beigt darbu (b)");
            while (true)
            {
                Console.Write("Darbiba: ");
                string darbiba = Console.ReadLine().ToLower();
                if(darbiba == "b")
                {
                    break;
                }
                switch (darbiba)
                {
                    case "i":
                        Console.Write("Ievadi summu: ");
                        double summa = Convert.ToDouble(Console.ReadLine());
                        Iemaksat(summa);
                        break;
                    case "p":
                        PirktDzerienu();
                        break;
                    case "a":
                        IzdotAtlikumu();
                        break;
                }
            }
        }
    }
}
