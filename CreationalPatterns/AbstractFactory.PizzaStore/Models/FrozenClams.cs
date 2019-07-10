using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.PizzaStores.Models
{
    public class FrozenClams: IClams
    {
        public string Name = "Frozen Clams";
        public override string ToString()
        {
            return Name;
        }
    }
}
