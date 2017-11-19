using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataKlondike
{
    public class FoundationPile : IPile
    {
        Stack<Card> cards;

        public FoundationPile()
        {
            this.cards = new Stack<Card>();
        }

        public bool IsEmpty
        {
            get
            {
                return !cards.Any();
            }
        }

        public bool Move(IPile target)
        {
            return true;
        }

        public bool Pop()
        {
            throw new NotImplementedException();
        }

        public bool PopRefactor(IPile target)
        {
            if(target is StockPile)
            {
                return false;
            }

            var card = this.cards.Peek();
            var pushed = target.Push(card);

            if(pushed)
            {
                this.cards.Pop();
            }

            return pushed;
        }

        public bool Push(Card card)
        {
            if(this.IsEmpty && card.Number == 1)
            {
                cards.Push(card);
                return true;
            }
            if(!this.IsEmpty && card.Number == cards.Peek().Number + 1)
            {
                cards.Push(card);
                return true;
            }
            return false;
        }
    }
}
