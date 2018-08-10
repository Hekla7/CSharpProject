using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    class Player
    {
        // 1. ipahiba Cards (List<Card>)
        public List<Card> Cards;
        // 2. konstruktors (bez parametriem)
        //2.1 define Cards sarakstu
        public Player()
        {
            Cards = new List<Card>();
        }

        // 3. int countPoints() - saskaita visus Cards punktus
        public int CountPoint()
        {
            int points = 0;
            int aceCount = 0;
            //3.1. foreach()
            // 3.2. ->GetPoints()
            foreach(Card c in Cards)
            {
                points += c.GetPoint();
                if (c.Value == "A")
                {
                    aceCount++;
                }
                //3.3. todo - apstradat duzhus
                while (points > 21 && aceCount > 0)
                {
                    points -= 10;
                    aceCount--;
                }
                
            }
            return points;
        }
        //4. void giveCards(Card card) - pievieno karti sarakstam
        public virtual void GiveCard(Card card)
        {
            Cards.Add(card);
            Console.WriteLine("Speletajs sanjema: " + card.Suit + card.Value);
            Console.WriteLine("Punkti = " + CountPoint());
        }
        // 5.  needCard() - vai nepiecieshama vel karts?
        public virtual bool NeedCard()
        {
            if (CountPoint() > 21)
            {
                return false;
            }
            Console.Write("Vai nepiecieshama karts (j/n)? ");
            string atbilde = Console.ReadLine();
            if (atbilde.ToLower() == "j")
            {
                return true;
            }
            else
            {
                return false;
            }
            // vai: 
            // return atbilde.ToLower();
        }
    }
}
