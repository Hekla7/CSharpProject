using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    class AtrumaParkapejs
    {
        public static void AtrumaSkaitishana()
        {
            int atrums = 0;
            int sods;
            string dzimene;
            Console.Write("Atrums: ");
            atrums = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dzimshanas diena?(J/N): ");
            dzimene = Console.ReadLine();

            if (atrums <= 60)
            {
                if (dzimene == "N")
                {
                    
                    sods = 0;
                    Console.Write(sods);
                }
                else if (dzimene == "J")
                {
                    if (atrums <= 60 + 5)
                    {
                        
                        sods = 0;
                        Console.Write(sods);
                    }
                }
            }
            else if (atrums >= 61)
            {
                if (dzimene == "N") {
                    if (atrums <= 80)
                    {

                        sods = 1;
                        Console.Write(sods);
                    }
                }
                else if (dzimene == "J"){
                    if (atrums <= 80+5)
                    {

                        sods = 0;
                        Console.Write(sods);
                    }
                }
                }
             
                else if (atrums > 80)
                {
                    if (dzimene == "N")
                    {
                       
                        sods = 2;
                        Console.Write(sods);
                    }
                    else if (dzimene == "J")
                    {
                        if (atrums > 80 + 5)
                        {
                            
                            sods = 2;
                            Console.Write(sods);
                        }
                    }
                    else
                    {
                        Console.Write("Something is not ok");
                    }

                }
            }
        }
    }


//if (irDz == "J"){
//    atrums -=5;
//    }
//    if (atrmus <= 60>) {
//    Console.Write ("0");
//    }
//    else if ( atrums> 60 && atrums <= 80>) {
//    Console.Write ("1"); 
//    }
//    else {
//    Console.Write ("2");
// isakais variants