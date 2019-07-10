using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.PizzaStores.Models;

namespace FactoryMethod.PizzaStores.Store
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }

            if (type.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }

            return null;
        }
    }
}