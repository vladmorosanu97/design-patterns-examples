using System;
using Decorator.StarbuzzCoffee.Beverages;
using Decorator.StarbuzzCoffee.Decorators;
using Decorator.StarbuzzCoffee.Models;

namespace Decorator.StarbuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso(Size.Grande);
            Console.WriteLine(beverage.GetDescription() + " | " + beverage.Cost());

            Beverage beverage2 = new Expresso(Size.Grande);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " | " + beverage2.Cost());

        }
    }
}
