using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.PizzaStores.Models
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Style Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
        }
    }
}