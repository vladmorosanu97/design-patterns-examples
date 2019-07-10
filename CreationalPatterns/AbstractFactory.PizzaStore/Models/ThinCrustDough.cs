using System;
using System.Collections.Generic;
using System.Text;using AbstractFactory.PizzaStores.Models;

namespace AbstractFactory.PizzaStores.Models
{
    public class ThinCrustDough: IDough
    {
        public string Name = "Thin Crust Dough";
        public override string ToString()
        {
            return Name;
        }
    }
}
