using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.PizzaStores.Models;

namespace FactoryMethod.PizzaStores.Store
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }

            if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }

            return null;
        }
    }
}