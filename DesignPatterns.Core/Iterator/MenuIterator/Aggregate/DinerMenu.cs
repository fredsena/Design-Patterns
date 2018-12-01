using DesignPatterns.Core.Iterator.MenuIterator.Iterator;

namespace DesignPatterns.Core.Iterator.MenuIterator.Aggregate
{
    public class DinerMenu : IMenu
    {
        private static readonly int MAX_ITEMS = 6;
        private readonly string[] menuItems = new string[MAX_ITEMS];

        public DinerMenu()
        {
            menuItems[0] = "Vegetarian BLT";
            menuItems[1] = "BLT";
            menuItems[2] = "Soup of the day";
            menuItems[3] = "Hotdog";
            menuItems[4] = "Steamed Veggies and Brown Rice";
            menuItems[5] = "Pasta";
        }

        public string[] GetMenuItems() => menuItems;

        public string toString() => "Diner Menu";

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
