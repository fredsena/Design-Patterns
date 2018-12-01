using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Iterator.MenuIterator.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
