using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.PizzaStores.Models;

namespace AbstractFactory.PizzaStores.IngredientsFactories
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IClams CreateClams();
    }
}