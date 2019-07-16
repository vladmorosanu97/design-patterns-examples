using Decorator.StarbuzzCoffee.Beverages;

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
