using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataKlondike
{
    public class CardType
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public CardType(string name, Color color)
        {
            Name = name;
            Color = color;
        }
        public static CardType Spade
        {
            get
            {
                return new CardType("Spade", Color.Black);
            }
        }
        public static CardType Club
        {
            get
            {
                return new CardType("Club", Color.Black);
            }
        }
        public static CardType Diamond
        {
            get
            {
                return new CardType("Diamond", Color.Red);
            }
        }
        public static CardType Heart
        {
            get
            {
                return new CardType("Heart", Color.Red);
            }
        }

        public override bool Equals(object obj)
        {
            return ((CardType)obj).Name.Equals(Name);
        }
    }
}
