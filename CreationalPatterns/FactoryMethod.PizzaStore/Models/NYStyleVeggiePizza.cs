using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.PizzaStores.Models
{
    public class NYStyleVeggiePizza: Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
        }
    }

}
