using System.Collections.Generic;
using Iterator.Restaurants.Iterators;
using Iterator.Restaurants.Models;

namespace Iterator.Restaurants.Menus
{
    public class DinnerMenu: IMenu
    {
        private static int _maxItems = 6;
        private int _numberOfItems = 0;

        private readonly List<MenuItem> _menuItems;

        public DinnerMenu()
        {
            MenuItem item1 = new MenuItem("Vegetarian BLT", "Pancakes with scrambled eggs", true, 3.10);
            MenuItem item2 = new MenuItem("BLT", "Pancakes with fried eggs", false, 4.10);
            MenuItem item3 = new MenuItem("Soup of the day", "Pancakes with fresh blueberries", true, 5.10);
            MenuItem item4 = new MenuItem("Hotdog", "Waffles", true, 6.10);

            _menuItems = new List<MenuItem> {item1, item2, item3, item4};
        }

        public void AddItem(MenuItem menuItem)
        {
            if (_numberOfItems < _maxItems)
            {
                _menuItems.Add(menuItem);
                _numberOfItems++;
            }
        }

        public void RemoveItem(int index)
        {
            if (_numberOfItems > 0 && _menuItems[index] != null)
            {
                var menuItem = _menuItems[index];
                _menuItems.Remove(menuItem);
                _numberOfItems--;
            }
        }

        public IIterator CreateIterator()
        {
            return new DinnerMenuIterator(_menuItems);
        }
    }
}
