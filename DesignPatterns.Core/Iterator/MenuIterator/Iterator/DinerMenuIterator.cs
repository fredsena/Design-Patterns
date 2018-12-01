using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Iterator.MenuIterator.Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private readonly string[] _items;
        private int position;

        public DinerMenuIterator(string[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (position >= _items.Length || _items[position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            string menuItem = _items[position];
            position++;
            return menuItem;
        }
    }
}
