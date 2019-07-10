using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.PizzaStores.Models
{
    public class MarinaraSauce: ISauce
    {
        public string Name = "Marinara Sauce";
        public override string ToString()
        {
            return Name;
        }
    }
}
