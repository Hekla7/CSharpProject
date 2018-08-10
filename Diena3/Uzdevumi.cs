using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
    public class Uzdevumi
    {
        public static void Uzdevums1()
        {
            Console.Write("Ievadiet valsti: ");
            string valsts = Console.ReadLine();
            valsts = Char.ToUpper(valsts[0]) + valsts.Substring(1);
            switch (valsts)
            {
                case "Igaunija":
                    Console.Write(valsts + " galvaspilseta ir Tallina");
                    break;
                case "Somija":
                    Console.Write("Helsinki");
                    break;
                case "Ukraina":
                    Console.Write("Kijeva");
                    break;
                case "Zviedrija":
                    Console.Write("Stokholma");
                    break;
                case "Krievija":
                    Console.Write("Maskava");
                    break;
                default:
                    Console.Write("ooops, don't know");
                    break;

            }
        }
        public static void Uzdevums2()
        {
            // i = i+1;
            //i++;
            //i+=1;

            // i = i+2;
            // i+=2
            //  for(int skaitlis =1; skaitlis<10; skaitlis++)
            //ctrl+k,ctrl+c(aizkomentet){
            //    Console.WriteLine(skaitlis);
            //}
            Console.Write("Ievadi dzimshanas gadu: ");
            int dzimgads = Convert.ToInt32(Console.ReadLine());
            for (int i = dzimgads; i <= DateTime.Now.Year; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Uzdevums3()
        {
            Console.Write("Ievadi N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                int kvadrats = i * i;
                Console.WriteLine(i + "=> " + kvadrats);
            }

        }
        // summu jasaskaita  public static void Uzdevums4()
        public static void Uzdevums4()
        {
            Console.Write("Ievadiet naturalo skaitli: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            for (int i = 1; i < N; i++)
            {
                // summa = summa + i;
                summa += i;
                Console.WriteLine(i);
            }
            Console.Write("Summa = " + summa);
        }
        public static void Uzdevums5()
        {
            Console.Write("Ievadi skaitlju daudzumu: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            int average = 0;
            Console.Write("Ievadi skaitljus: ");
            int skaitlji = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= skaitlji; i++)
            {
                summa += i;
                average = summa / i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Summa ir: " + summa);
            Console.WriteLine("Videjais ir: " + average);
        }
        public static void Uzdevums6()
        {
            Console.Write("Ievadi skaitu N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int y = 1; y <= N; y++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static void Uzdevums7()
        {
            Console.Write("Ievadi rindu skaitu N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= N; x++)
            {

                for (int y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
        }
        public static void Uzdevums8()
        {
            Console.Write("Ievadi skaitu rindaam N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int r = 1; r <= N; r++)
            {// attelo tukshumus trijsturim
                for (int y = 1; y <= N - r; y++)
                {
                    Console.Write(" ");
                }
                //attelo zvaigznites
                for (int z = 1; z <= 2 * r - 1; z++)
                    Console.Write("*");
            }
            // parejam jaunaa rindaa
            Console.WriteLine();

            for (int r = N - 1; r >= N; r--)
            {// attelo tukshumus trijsturim
                for (int y = 1; y <= N - r; y++)
                {
                    Console.Write(" ");
                }
                //attelo zvaigznites
                for (int z = 1; z <= 2 * r - 1; z++)
                    Console.Write("*");
            }
            // parejam jaunaa rindaa
            Console.WriteLine();
        }


        public static void WhilePiemers()
        {
            // lietotajs ievada skaitljus
            // ievadi partrauc ar - 1
            int sk = 0;
            int summa = 0;
            while (sk != -1)
            {
                Console.Write("Ievadi skaitli vai - 1, lai partrauktu: ");
                sk = Convert.ToInt32(Console.ReadLine());
                if (sk != -1)
                {
                    //summa = summa + sk

                    summa += sk;
                    Console.Write("Summa = " + summa);

                    int summa2 = 0;
                    while (true)
                    //for(;;)
                    {
                        Console.Write("Ievadi skaitli vai - 1, lai partrauktu: ");
                        int sk2 = Convert.ToInt32(Console.ReadLine());
                        if (sk2 == -1)
                        {
                            break;
                        }
                        else
                        {
                            summa2 += sk2;
                        }
                    }
                    Console.Write("Summa2 = " + summa2);
                }
            }
        }
    }
}

