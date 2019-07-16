using System.Collections.Generic;
using Iterator.Restaurants.Menus;

namespace Iterator.Restaurants.Iterators
{
    public class MenuIterator: IIterator
    {
        private readonly List<IMenu> _menus;
        private int _position = 0;
        public MenuIterator(List<IMenu> menus)
        {
            _menus = menus;
        }

        public bool HasNext()
        {
            if (_position >= _menus.Count || _menus[_position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            IMenu menu = _menus[_position];
            _position++;
            return menu;
        }
    }
}
