using System;
using System.Collections.Generic;
using System.Text;
using Decorator.StarbuzzCoffee.Beverages;
using Decorator.StarbuzzCoffee.Models;

namespace Decorator.StarbuzzCoffee.Decorators
{
    public abstract class CondimentDecorator: Beverage
    {
        protected Beverage Beverage;

        protected CondimentDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }
    }
}
