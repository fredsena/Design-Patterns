using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Core.Iterator.MenuIterator.Iterator;

namespace DesignPatterns.Core.Iterator.MenuIterator.Aggregate
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<string> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<string> {
                "K&B's Pancake Breakfast",
                "Couscuz Breakfast",
                "Blueberry Pancakes",
                "Waffles"};
        }

        public void AddItem(string item) => menuItems.Add(item);

        public List<string> GetMenuItems() => menuItems;

        public string ToString() => "Pancake House Menu";

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
