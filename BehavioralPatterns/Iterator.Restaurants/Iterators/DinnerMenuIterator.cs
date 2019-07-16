using System.Collections.Generic;
using Iterator.Restaurants.Models;

namespace Iterator.Restaurants.Iterators
{
    public class DinnerMenuIterator: IIterator
    {
        private readonly List<MenuItem> _menuItems;
        private int _position = 0;
        public DinnerMenuIterator(List<MenuItem> menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            if (_position >= _menuItems.Count || _menuItems[_position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            MenuItem menuItem = _menuItems[_position];
            _position++;
            return menuItem;
        }
    }
}
