using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
    class FizzBuzz
    {
        public static void FizzorBuzz()
        {
            Console.Write("Ievadiet skaitli A (sakums): ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ievadiet skaitli B (beigums): ");
            int B = Convert.ToInt32(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.Write("FizzBuzz");
                else if (fizz)
                    Console.Write("Fizz");
                else if (buzz)
                    Console.Write("Buzz");
                else
                    Console.Write(i);
                
                //if (i % 3 == 0)
                //{
                //    i.ToString();

                //    Console.Write("Fizz");

                //}
                //    else if (i % 5 == 0)
                //    {
                //       Console.Write("Buzz");
                //   }
                //  else if (i % 5 == 0 && i % 3 == 0)
                //   {
                //       Console.Write("FizzBuzz");
                //  }
                //else {
                //    Console.Write(i);
                //}
            }
            }
        }
    }

