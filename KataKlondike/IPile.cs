using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataKlondike
{
    public interface IPile
    {
        bool Pop();
        bool PopRefactor(IPile target);
        bool Push(Card card);
        bool Move(IPile target);
        bool IsEmpty { get; }
    }
}
