using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.PizzaStores.Models
{
    public class ReggianoCheese: ICheese
    {
        public string Name = "Reggiano Cheese";
        public override string ToString()
        {
            return Name;
        }
    }
}
