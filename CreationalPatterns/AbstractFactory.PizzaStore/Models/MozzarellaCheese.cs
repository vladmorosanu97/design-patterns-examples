using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.PizzaStores.Models
{
    public class MozzarellaCheese: ICheese
    {
        public string Name = "Mozzarella Cheese";
        public override string ToString()
        {
            return Name;
        }
    }
}