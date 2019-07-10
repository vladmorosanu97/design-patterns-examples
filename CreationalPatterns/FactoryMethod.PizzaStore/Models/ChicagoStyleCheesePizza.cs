﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.PizzaStores.Models
{
    public class ChicagoStyleCheesePizza: Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public new void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
