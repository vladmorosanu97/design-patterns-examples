using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.PizzaStores.Models
{
    public class FreshClams : IClams
    {
        public string Name = "Fresh Clams";

        public override string ToString()
        {
            return Name;
        }
    }
}