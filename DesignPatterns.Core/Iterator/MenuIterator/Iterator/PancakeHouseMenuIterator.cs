using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Core.Iterator.MenuIterator.Iterator
{
    public class PancakeHouseMenuIterator : IIterator
    {
        readonly List<string> _items;
        private int position;

        public PancakeHouseMenuIterator(List<string> items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            return position < _items.Count;
        }

        public object Next()
        {
            string menuItem = _items[position];
            position++;
            return menuItem;

        }
    }
}
