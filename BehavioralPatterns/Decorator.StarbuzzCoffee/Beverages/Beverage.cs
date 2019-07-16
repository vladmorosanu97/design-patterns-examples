using Decorator.StarbuzzCoffee.Models;

namespace Decorator.StarbuzzCoffee.Beverages
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";
        public Size Size { get; protected set; }
        public abstract string GetDescription();

        public abstract double Cost();
    }
}