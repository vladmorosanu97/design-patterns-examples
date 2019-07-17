using System;
using System.Collections.Generic;
using Composite.Restaurants.Iterators;

namespace Composite.Restaurants.Menus
{
    public class MenuItem : MenuComponent
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public bool IsVegetarian { get; protected set; }
        public double Price { get; protected set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override void Print()
        {
            Console.WriteLine( " " + Name);
            if (IsVegetarian)
            {
                Console.WriteLine("(v)");
            }

            Console.WriteLine(", " + Price);
            Console.WriteLine("    -- " + Description);
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }
    }
}