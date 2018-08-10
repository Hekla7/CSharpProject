using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    class Dilstosha_virkne
    {
        public static void DilstoshaVirkne()
        {
            Console.Write(" Ievadi skaitli no N lidz 1: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = N; i>=1; i--)
            {
                Console.WriteLine(i);
            }
        }
        public class Modinatajs {
           string laiks;
           string diena;
           string atvalinajums;
            public static void Modinat() {
                string laiks;
                string diena;
                string atvalinajums;
                Console.Write(" Ievadi dienu: ");
                diena = Console.ReadLine();
                Console.Write(" Ievadi atvalinajuma statusu(J/N): ");
                atvalinajums = Console.ReadLine();
                if (atvalinajums == "J")
                {
                    if (diena == "P" || diena == "O" || diena == "T" || diena == "C"
                          || diena == "Pk")
                    {
                        laiks = "10:00";
                        Console.Write("Modinatajam jazavana: " + laiks);
                    }
                    else if (diena == "Se" || diena == "Sv")
                    {
                        laiks = "Off";
                        Console.Write("Modinatajam jabut: " + laiks);
                    }
                    else
                    {
                        Console.Write("Incorrect input");
                    }
                    Console.ReadLine();
                    }
                if (atvalinajums == "N")
                {
                    if (diena == "P" || diena == "O" || diena == "T" || diena == "C"
                          || diena == "Pk")
                    {
                        laiks = "7:00";
                        Console.Write("Modinatajam jazavana: " + laiks);
                    }
                    else if (diena == "Se" || diena == "Sv")
                    {
                        laiks = "10:00";
                        Console.Write("Modinatajam jabut: " + laiks);
                    }
                    else
                    {
                        Console.Write("Incorrect input");
                    }
                    Console.ReadLine();
                }
            }

        }
    }
}
// Console.Write(irAtvalin == "J" ? "10:00" : "7:00"); 
// ja irAtvalin ir J tad 10:00, citadi - 7:00