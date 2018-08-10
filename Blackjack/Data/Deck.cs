using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    class Deck
    {
        public string[] Suits = { "H", "S", "D", "C" };
        public string[] Values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Q", "K", "A", "J" };
        //1. ipashiba Cards (List<Card>)
        public List<Card> Cards; 
        //2. konstruktors (bez parametriem)
        public Deck() {
            Cards = new List<Card>();
            foreach (string suit in Suits)
            {
                foreach(string value in Values)
                {
                    Cards.Add(new Card(suit, value));
                }
            }
        }
        // 2.1. aizpilda karshu sarakstu ar visam 52 kartim

        // 3.  void shuffle() - sajauc Cards

        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList();
        }
        // 4. Card getCard() - atgriezh vienu karti no saraksta un dzesh no saraksta
        public Card GetCard()
        {
            //4.1 panjem karti no saraksta
            Card card = Cards[0];
            //4.2. izdesh no saraksta
            Cards.Remove(card);
            // 4.3. atgriezh ka rezultatu
            return card;
        }
    }
}
