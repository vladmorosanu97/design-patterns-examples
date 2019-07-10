﻿using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.PizzaStores.Models;

namespace FactoryMethod.PizzaStores.Store
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
