using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.PizzaStores.IngredientsFactories;

namespace AbstractFactory.PizzaStores.Stores
{
    public class CheesePizza: Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
            Name = "Cheese pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Clams = _pizzaIngredientFactory.CreateClams();
        }
    }
}
