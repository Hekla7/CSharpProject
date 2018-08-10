using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    class Program
    {
        static void Main(string[] args)
        {
            IedzivotajsAdrese();
            Console.ReadLine();
            Uzdevumi.Uzdevums24();
            Console.ReadLine();

        }
        static void SarakstaPiemers()
        {
            List<int> saraksts = new List<int>();
            saraksts.Add(5);
            saraksts.Add(10);
            saraksts.Add(17);

            foreach (int sk in saraksts)
            {
                Console.WriteLine(sk);
            }
            for (int i = 0; i < saraksts.Count; i++)
            {
                Console.WriteLine(saraksts[i]);
            }
        }
        static void Uzdevums25()
        {
            List<int> skaitlji = new List<int>();
            while (true)
            {
                Console.Write(" Ievadi skaitli vai 0, lai partrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break;
                }
                skaitlji.Add(skaitlis);
            }
            for (int i = skaitlji.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(skaitlji[i]);
            }
        }
        static void Uzdevums26()
        {
            List<int> skaitlji = new List<int>();
            while (true)
            {
                Console.Write(" Ievadi skaitli vai 0, lai partrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break;
                }
                skaitlji.Add(skaitlis);
            }

            //Izvade:
            // cik skaitlji 5 ir starp lietotaja ievaditajiem
            int skaits = 0;
            foreach (int skaitlis in skaitlji)
            {
                if (skaitlis == 5)
                {
                    skaits++;
                }
            }
            Console.Write("Atrasti " + skaits + " piecinieki");
        }
        static void Uzdevums27()
        {
            List<int> skaitlji = new List<int>();
            while (true)
            {
                Console.Write(" Ievadi skaitli vai 0, lai partrauktu: ");
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                if (skaitlis == 0)
                {
                    break;
                }
                skaitlji.Add(skaitlis);
            }
            //int min = skaitlji.Min;
            int min = skaitlji[0];
            int max = skaitlji[0];
            foreach (int skaitlis in skaitlji)
            {
                if (skaitlis < min)
                {
                    min = skaitlis;
                }
                else if (skaitlis > max)
                {
                    max = skaitlis;
                }
            }
            Console.WriteLine(" min = " + min);
            Console.WriteLine("max = " + max);
        }

        static void MasivaPiemers()
        {
            //int skaitlis1 = 5;
            //int skaitlis2 = 10;
            int[] saraksts = new int[3];
            saraksts[0] = 5;
            saraksts[1] = 10;
            saraksts[2] = 19;
            // saraksts[3] -> izmetis kljudu

            int[] saraksts2 = { 5, 10, 19 };
            int skaitsMasiva = saraksts.Length; //3
            // izvadis 5, 10, 19
            for (int i = 0; i < saraksts.Length; i++)
            {
                //izvada skaitli pozicijaa "i"
                Console.WriteLine(saraksts[i]);
            }
            // izvadis 5 10 19
            foreach (int skaitlis in saraksts2)
            {
                Console.WriteLine(skaitlis);
            }
        }
        static void IedzivotajsAdrese()
        {
            Iedzivotajs iedz = new Iedzivotajs();
            iedz.Vards = "Andris";
            iedz.Uzvards = "Berzinsh";
            iedz.Dzivesvieta = new Adrese();
            iedz.Dzivesvieta.Valsts = "Latvija";
            iedz.Dzivesvieta.Pilseta = "Riga";
            iedz.Dzivesvieta.Iela = "Brivibas gatve";
            iedz.Dzivesvieta.MajasNr = "100";
            iedz.Dzivesvieta.DzivoklaNr = 5;

            iedz.Apraksts();
        }
        public void Uzdevums28()
        {
            List<Prece> saraksts = new List<Prece>();
            saraksts.Add(new Prece("Dators", 900));
            saraksts.Add(new Prece("Bikses", 50));
            saraksts.Add(new Prece("Auto", 1000));
            saraksts.Add(new Prece("Mobilais", 50));
            //....

            // 1. jaizvada viss katalogs foreach
            Console.WriteLine("Pieejamas preces: ");
            foreach (var p in saraksts)
            {
                Console.WriteLine(p.Nosaukums + "$" + p.Cena);
            }
            // lietotajs ievada preces nosaukumu
            // ievadi partrauc ar "0" - if() un while()
            while (true)
            {
                Console.Write("Ievadi preci(vai 0 lai partrauktu): ");
                string nosaukums = Console.ReadLine();
                if (nosaukums == "0")
                {
                    break;
                }
                //jaatrod ievadita prece katalogaa (pec nosaukuma)
                //panjem atrastas preces cenu un pieskaitaat kopsummai
                double summa = 0;
                foreach (var pr in saraksts)
                {
                    if (pr.Nosaukums.Equals(nosaukums, StringComparison.OrdinalIgnoreCase))
                    {
                        summa += pr.Cena;
                        break; // partraucam mekleshanu
                    }
                }

                //izvada kopsummu
                Console.Write("Summa = $ " + summa);
            }
        }
    }
}