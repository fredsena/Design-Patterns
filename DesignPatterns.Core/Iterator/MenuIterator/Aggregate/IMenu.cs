using DesignPatterns.Core.Iterator.MenuIterator.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Iterator.MenuIterator.Aggregate
{
    public interface IMenu
    {
        IIterator CreateIterator();
    }
}
