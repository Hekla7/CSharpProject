using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
   public class Karatavs
    {

        //ipashibas:
        //1. vardu saraksts (List<string>)
        List<String> Vardi;
        //2. minamais vards (char[]), piemeram AKA
        char[] MinamaisVards;
        //3. atminetais vards (char[]), piemeram, _K_
        char[] AtminetaisVards;

        int atlikusieMeginajumi;
        // KONSTRUKTORS:
        //1. aizpilda  vardu sarakstu
        public Karatavs()
        {
            Vardi = new List<string>()
            {
                "APPLE",
                "SUN",
                "ICE",
            };
        }
        //METODES: 
        //1. uzsakt jaunu speli
        public void StartNewGame()
        {
            Random rnd = new Random();
            Vardi = Vardi.OrderBy(v => rnd.Next()).ToList();
            string vards = Vardi[0];
            MinamaisVards = new char[vards.Length];
            AtminetaisVards = new char[vards.Length];

            for (int i = 0; i < vards.Length; i++)
            {
                MinamaisVards[i] = vards[i];
                AtminetaisVards[i] = '_';
                atlikusieMeginajumi = 5;
            }

            Console.WriteLine(string.Join(" ", AtminetaisVards));
        }
        // 1.1. random jaizvelas vards no saraksta
        // 1.2. aizpildit "minamais" vards ar varda burtiem
        // 1.3. aizpildit "atminetais vards" ar "_"
        //1.4. lietotajam izvada "atminetais vards" ar "_"

        //2. minet burtu, sanjem vienu parametru - burtu
        public void MinetBurtu(char burts)
        {
            bool vaiIrVarda = false;
            for (int i = 0; i < MinamaisVards.Length; i++)
            {
                if (Char.ToUpper(MinamaisVards[i]) == Char.ToUpper(burts))
                {
                    if (AtminetaisVards[i] != burts)
                    {
                        AtminetaisVards[i] = burts;
                        vaiIrVarda = true;
                    }
                    else
                    {
                        Console.WriteLine("Shis burts jau ir atminets");
                        return;
                    }
                   
                }
            }
            if (vaiIrVarda)
            {
                Console.WriteLine(String.Join(" ", AtminetaisVards));
            }
            else
            {
                Console.WriteLine("Burts nav shaja vardaa");
                atlikusieMeginajumi--;
                Console.WriteLine("Atlikushie meginajumi: " + atlikusieMeginajumi);
            }
            
        }
        public bool VaiIrMeginajumi()
        {
            return atlikusieMeginajumi > 0;
        }
        // 2.1. parbaudit, vai burts ir "minamais vards" masivaa
        // 2.2. ja ir, tad aizstaj "atminetais vards" svitrinju taja pashaa pozicija ar burtu
        //char[] MinamaisVards;
        //char[] AtminetaisVards;
        // 3. vai vards ir atminets
        // 3.1. vai "atminetais vards" satur '_'
        public bool VaiIrAtminets()
        {
            bool irAtminets = true;
            foreach (char burts in AtminetaisVards)
            {
                if (burts == '_')
                {
                    irAtminets = false;
                    break;
                }
            }
            return irAtminets;
        }
        public string Vards()
        {
            return new string(MinamaisVards);
        }
    }
}
    
        
        

