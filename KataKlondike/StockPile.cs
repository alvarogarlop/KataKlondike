using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataKlondike
{
    public class StockPile : IPile
    {
        public StockPile()
        {

        }

        public bool IsEmpty
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Move(IPile target)
        {
            throw new NotImplementedException();
        }

        public bool Pop()
        {
            throw new NotImplementedException();
        }

        public bool PopRefactor(IPile target)
        {
            throw new NotImplementedException();
        }

        public bool Push(Card card)
        {
            throw new NotImplementedException();
        }
    }
}
