using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.PizzaStores.Models
{
    public class PlumTomatoSauce: ISauce
    {
        public string Name = "Plum Tomato Sauce";
        public override string ToString()
        {
            return Name;
        }
    }
}
