using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.PizzaStores.Models;

namespace AbstractFactory.PizzaStores.IngredientsFactories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }
    }
}