using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.PizzaStores.Models
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings = new List<string>();

        protected Pizza()
        {
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough " + Dough);
            Console.WriteLine("Adding sauce  " + Sauce);
            Console.WriteLine("Adding toppings ");
            foreach (var topping in Toppings)
            {
                Console.WriteLine(" " + topping + " ");
            }
        }

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
    }
}