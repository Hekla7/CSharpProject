using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Data
{
    class Dealer : Player
    {
        public override void GiveCard(Card card)
        {
            Cards.Add(card);
        }
        public override bool NeedCard()
        {
            // ja nav sasniegti 17 punki ir nepiecieshama karte
            return CountPoint() < 17;
        }
    }
}
