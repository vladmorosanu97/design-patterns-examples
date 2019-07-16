using System;
using System.Collections.Generic;
using Iterator.Restaurants.Iterators;
using Iterator.Restaurants.Menus;
using Iterator.Restaurants.Models;

namespace Iterator.Restaurants.Waitresses
{
    public class Waitress
    {
        private readonly List<IMenu> _menus;

        public Waitress(List<IMenu> menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            MenuIterator menuIterator = new MenuIterator(_menus);
            while (menuIterator.HasNext())
            {
                IMenu menu = menuIterator.Next() as IMenu;
                PrintMenu(menu.CreateIterator());
            }
        }

        private void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next() as MenuItem;
                Console.WriteLine($"{menuItem.Name}, {menuItem.Description}, {menuItem.Price}, {menuItem.Vegetarian}");
            }
        }


    }
}
