using System;
using System.Collections.Generic;
using System.Text;
using Composite.Restaurants.Menus;

namespace Composite.Restaurants.Waitresses
{
    public class Waitress
    {
        private readonly MenuComponent _menuComponent;

        public Waitress(MenuComponent menuComponent)
        {
            _menuComponent = menuComponent;
        }

        public void Print()
        {
            _menuComponent.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator<MenuComponent> iterator = _menuComponent.CreateIterator();

            Console.WriteLine("\n VEGETARIAN MENU \n --------");
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                menuComponent.Print();
            }
        }
    }
}