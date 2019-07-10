using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.PizzaStores.Models;

namespace AbstractFactory.PizzaStores.IngredientsFactories
{
    public class NYPizzaIngredientFactory: IPizzaIngredientFactory
    {
        
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }
    }
}
