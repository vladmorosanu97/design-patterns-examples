using System;
using System.Collections.Generic;
using Composite.Restaurants.Iterators;

namespace Composite.Restaurants.Menus
{
    public class Menu : MenuComponent
    {
        private readonly IEnumerator<MenuComponent> _iterator = null;

        private readonly List<MenuComponent> _menuComponents;
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
            _menuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return _menuComponents[index];
        }

        public override void Print()
        {
            Console.WriteLine("\n" + Name);
            Console.WriteLine(", " + Description);
            Console.WriteLine("--------------------------");

            var iterator = _menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                menuComponent.Print();
            }

            iterator.Dispose();
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            if (_iterator == null)
            {
                return new CompositeIterator(_menuComponents.GetEnumerator());
            }

            return _iterator;
        }
    }
}