using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataKlondike
{
    public class Card
    {
        public int Number { get; set; }
        public CardType Type { get; set; }

        public Card(int number, CardType type)
        {
            this.Number = number;
            this.Type = type;
        }
    }
}
