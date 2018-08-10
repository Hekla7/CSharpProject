using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Piemers();
            //Vecums();
            //Salidzinat();
            Kalkulators();
            Console.ReadLine();
        }

        static void Piemers()
        {
            int skaitlis = AtgriezSkaitlis();
            if (skaitlis > 10)
            {
                Console.Write("Skaitlis ir lielaks par 10");
            }
            else if (skaitlis == 10)
            {
                Console.Write("Skaitlis ir vienads ar 10");
            }
            else if (skaitlis == 11)
            {
                Console.Write("Skaitlis ir vienads ar 11");
            }
            else
            {
                Console.Write("Skaitlis ir mazaks par 10");
            }
        }


        static int AtgriezSkaitlis()
        {
            return 15;
        }

        static void Vecums()
        {
            // pieprasit ievadit vecumu
            Console.Write("Ievadiet vecumu: ");
            // parbaudit vai vecums ir lielaks/mazaks par 18
            int vecums = Convert.ToInt32(Console.ReadLine());
            if (vecums > 18)
            {
                Console.Write("Esi pilngadigs");
            }
            else
            {
                Console.Write("Neesi pilngadigs");
            }
        }
        static void Salidzinat()
        {
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
            if (skaitlis1 == skaitlis2)
            {
                Console.Write("Skaitlji ir vienadi");
            }
            else
            {
                Console.Write("Skaitlji nav vienadi");
            }

        }
        static void MeneshuNosaukums()
        {
            string menesis = Console.ReadLine().ToLower();

            int dienas = Convert.ToInt32(Console.ReadLine());
            if (menesis == "April")
            {
                Console.Write("31 dienas");
            }
            else if (menesis == "February")
            {
                Console.Write("28 dienas");
            }
            else if (menesis == "apr" || menesis == "jun" || menesis == "sep" || menesis == "nov")
            {
                Console.Write("30 dienas");
            }
            else
            {
                Console.Write("31 dienas");
            }
        }
        static void GraduParvershana()
        {
            string mervieniba1 = "F";
            string mervieniba2 = "K";
            int gradi = 5;
            if(mervieniba1!= "F" || mervieniba1 != "C" || mervieniba1 != "K" 
                || mervieniba2 != "C" || mervieniba2 != "F" || mervieniba2 != "K")
            {
                Console.Write("Kljuda ievadee");
            }
            else if (mervieniba1==mervieniba2)
            {
                Console.Write("Gradi= " + gradi + mervieniba1);
            }
            else if (mervieniba1=="F")
            {
                if(mervieniba2== "C")
                {
                    double parveidotiegradi = gradi - 32 / 1.8;
                    Console.Write("C= " + parveidotiegradi);
                }
            }
        }

        static void Aprekini()
        {
            //ievade:
            // attalums (metros)
            Console.Write("Ivadi attalumu: ");
            decimal metri = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Ievadi laiku: ");
            //pateretais laiks
            //stundas
            // minutes
            // sekundes
            int stundas = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            int sekundes = Convert.ToInt32(Console.ReadLine());
            //izvade:
            //kopejais laiks
            int kopejaislaiks = sekundes + minutes * 60 + stundas * 60 * 60;
            //atrums(m/s) = attalums/laiks
            decimal atrums = metri / kopejaislaiks;
            // atrums(km/h)
            decimal atrumsKmh = (metri / 1000) / (kopejaislaiks / (60 * 60));
            // attalums kilometros
            decimal km = metri / 1000;
            //attalums judzes = attalums km * 0.621371
            decimal metrijudz = km * 0.621371m; // vai nu  (decimal)0.621371
            Console.Write("Kopejais laiks ir: " + kopejaislaiks);
            Console.Write("atrums m/s = " + metri);
            Console.Write("atrums km/h = " + atrumsKmh);
        }
        static void Kalkulators()
        {
            Console.Write("Ievadi 1.skaitli: ");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadi darbibu: ");
            string darb = Console.ReadLine();
            Console.Write("Ievadi 2.skaitli: ");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            if (darb == "+")
            {
                Console.Write(sk1 + sk2);
            }
            else if (darb == "-")
            {
                Console.Write(sk1 - sk2);
            }
            else if (darb == "*")
            {
                Console.Write(sk1 * sk2);
            }
            else if (darb == "/")
            {
                decimal dal = (decimal)sk1 / sk2;
                Console.Write("Starpiba ir: " + dal);
            }
            else {
                Console.Write("Nezinama darbiba");
            }
        }
    }
        }
