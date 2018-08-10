using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    class Table
    {
        private Deck deck;
        private Dealer dealer;
        private Player player;

        public Table()
        {
            deck = new Deck();
            dealer = new Dealer();
            player = new Player();
        }
        // 1. void Start new game
        public void StartNewGame()
        {
            Console.WriteLine("Bets are closed, good luck: ");
        
            //1.1. panjem jaunu karshu kavu
           
                deck = new Deck();
                dealer = new Dealer();
                player = new Player();
                // 1.2. samaisa kartis

                deck.Shuffle();
                // 1.3. speletajam pieshkir 2 kartis
                player.GiveCard(deck.GetCard());
                player.GiveCard(deck.GetCard());
                // 1.4. dilerim pieshkir 2 kartis
                dealer.GiveCard(deck.GetCard());
                dealer.GiveCard(deck.GetCard());
            }
            // 2. bool PlayAgain()
            
            //2.1. vaicaa lietotajam, vai uzsakt jaunu speli
            public bool PlayAgain()
            {
                Console.WriteLine("Vai uzsakt jauno speli? ");
            string answer = Console.ReadLine();

            return answer.ToLower() == "j";
            }
            //3. void ShowResults()
            public void ShowResults()
        {
            int playerPoints = player.CountPoint();
            int dealerPoints = dealer.CountPoint();
            Console.WriteLine("Dilera punkti: " + dealerPoints);
            Console.WriteLine("Speletaja punkti: " + playerPoints);
            if (playerPoints > 21)
            {
                Console.WriteLine("Tu zaudeji!");
            }
            else if (dealerPoints > 21)
            {
                Console.WriteLine("Tu uzvareji!");
            }
            else if (playerPoints == dealerPoints)
            {
                Console.WriteLine("Neizshkirts!");
            }
            else if (playerPoints > dealerPoints)
            {
                Console.WriteLine("Tu uzvareji!");
            }
            else
            {
                Console.WriteLine("Tu zaudeji!");
            }

        }
            //3.1. izvada rezultatu - kursh uzvareja 
         
            //4.1. void PlayerTurn()
            public void PlayerTurn()
        {
            while (player.NeedCard())
            {
                player.GiveCard(deck.GetCard());
            }
        }
        //4.1 dod kartis speletajam tik ilgi, kamer velas 

        //5. void DealerTurn()
        public void DealerTurn()
        {
            while (dealer.NeedCard())
            {
                dealer.GiveCard(deck.GetCard());
            }
        }
        // 5.1. dod kartis dilerim tik ilgi, kamer nepiecieshams



    }
    }


