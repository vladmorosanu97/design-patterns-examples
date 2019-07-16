using System.Collections.Generic;
using Iterator.Restaurants.Iterators;
using Iterator.Restaurants.Models;

namespace Iterator.Restaurants.Menus
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            MenuItem item1 = new MenuItem("K&B", "Pancakes with scrambled eggs", true, 3.10);
            MenuItem item2 = new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs", false, 4.10);
            MenuItem item3 = new MenuItem("Blueberry", "Pancakes with fresh blueberries", true, 5.10);
            MenuItem item4 = new MenuItem("Waffles", "Waffles", true, 6.10);

            _menuItems = new List<MenuItem> {item1, item2, item3, item4};
        }

        public void AddItem(MenuItem item)
        {
            _menuItems.Add(item);
        }

        public void RemoveItem(int index)
        {
            var menuItem = _menuItems[index];
            if (menuItem != null)
            {
                _menuItems.Remove(menuItem);
            }
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }
    }
}