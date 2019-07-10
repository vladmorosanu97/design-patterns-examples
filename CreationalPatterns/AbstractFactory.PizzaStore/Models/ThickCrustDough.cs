using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.PizzaStores.Models
{
    public class ThickCrustDough: IDough
    {
        public string Name = "Thick Crust Dough";
        public override string ToString()
        {
            return Name;
        }
    }
}
