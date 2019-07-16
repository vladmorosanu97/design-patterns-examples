using Decorator.StarbuzzCoffee.Beverages;

namespace Decorator.StarbuzzCoffee.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 0.20;
        }
    }
}