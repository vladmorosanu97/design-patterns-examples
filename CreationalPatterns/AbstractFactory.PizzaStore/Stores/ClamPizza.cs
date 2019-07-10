using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.PizzaStores.IngredientsFactories;

namespace AbstractFactory.PizzaStores.Stores
{
    public class ClamPizza: Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
            Name = "Clam Pizza";
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
