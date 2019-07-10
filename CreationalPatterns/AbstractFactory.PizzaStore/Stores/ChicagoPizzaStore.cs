using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.PizzaStores.IngredientsFactories;

namespace AbstractFactory.PizzaStores.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public ChicagoPizzaStore(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new CheesePizza(_pizzaIngredientFactory);
            }

            if (type.Equals("veggie"))
            {
                return new ClamPizza(_pizzaIngredientFactory);
            }

            return null;
        }
    }
}