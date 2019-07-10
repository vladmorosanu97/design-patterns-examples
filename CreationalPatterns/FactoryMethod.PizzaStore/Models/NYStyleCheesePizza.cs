using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.PizzaStores.Models
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
        }
    }
}