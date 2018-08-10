using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
    public class Uzdevumi
    {
        public static void Uzdevums28()
        {
            List<Prece> saraksts = new List<Prece>();
            saraksts.Add(new Prece("Sators", 900));
            //...
            // 1. jaizvada viss katalogs - foreach()
            //2. lietotajs ievada preces nosaukumu
            // 3. ievadi partrauc "0" - if() un while()
            //2.1. jaatrod ievadita prece katalogaa (pec nosaukuma) - foreeach ()
            //2.2. panjem atrasta s preces cenu un pieskaitat kopsummai
            // 3. Izvada kopsummu

        }
        public static void Uzdevums24()
        {
            
            
            int[] skaitli = { 0, 10, 20, 30, 40, 50 };
            Console.Write("Ievadi skaitli: ");
            int skaitlis =Convert.ToInt32(Console.ReadLine());
            // ar ciklu parbauda vai skaitlis atrodas masivaa

            // izvada poziciju kur skaitlis atrodas masivaa

            for (int i = 0; i < skaitli.Length; i++)
            {
                if (skaitlis == skaitli[i])
                {
                    Console.Write("Skaitlis atrasts pozicijaa " + i);
                    return;
                }
            }
                    Console.Write("Skaitlis nav atrasts!");
                }
            }
        }
    
