using System;
using System.Collections.Generic;
using System.Text;
using Decorator.StarbuzzCoffee.Beverages;
using Decorator.StarbuzzCoffee.Models;

namespace Decorator.StarbuzzCoffee.Decorators
{
    public class Whip: CondimentDecorator
    {
        public Whip(Beverage beverage): base(beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            double cost = Beverage.Cost();
            if (Beverage.Size == Size.Tall)
            {
                cost += 0.30;
            }
            else if (Beverage.Size == Size.Grande)
            {
                cost += 0.40;
            }
            else if (Beverage.Size == Size.Venti)
            {
                cost += 0.50;
            }

            return cost + 0.20;
        }
    }
}
