using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    class Card
    {
        // 1. ipashiba - suit (string)
        public string Suit;
        // 2. ipashiba - value (string)
        public string Value;
        // 3. konstruktors (aizpilda abas ipashibas)
        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }
        // 4. getPoint() - atgriezh karts skaitlisko vertibu
        public int GetPoint()
        {
            switch (Value)
            {
                case "A":
                    return 11;
                case "K":
                case "Q":
                case "J":
                    return 10;
                default:
                    // return Convert.ToInt32(Value);
                    return Int32.Parse(Value);
            }
        }
    }
}
