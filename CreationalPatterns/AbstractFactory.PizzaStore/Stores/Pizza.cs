using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.PizzaStores.Models;

namespace AbstractFactory.PizzaStores.Stores
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public IDough Dough { get; protected set; }
        public ISauce Sauce { get; protected set; }
        public IClams Clams { get; protected set; }
        public ICheese Cheese { get; protected set; }
        
        protected Pizza()
        {
        }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official Pizza Store box");
        }

        public override string ToString()
        {
            return Name + $", Ingredients: {Dough}, {Sauce}, {Clams}, {Cheese}";
        }
    }
}
