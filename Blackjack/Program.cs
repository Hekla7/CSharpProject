using Blackjack.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            while (true)
            {
                table.StartNewGame();
                table.PlayerTurn();
                table.DealerTurn();
                table.ShowResults();

                // parbaude vai uzsakt jauno speli
                //if(table.PlayAgain() == false)
                if (!table.PlayAgain())
                {
                    break;
                }
            }
            // 1. ja speletajam ir virs 21 punkta, tad partraukt vaicashanu --> player
            //2. pie rezultata izvadit abu dalibnieku rezult --> Table
            // 3. ciksliski uzsakt jauno speli --> Main

            

            Console.ReadLine();
        }
    }
}
