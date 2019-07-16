using Decorator.StarbuzzCoffee.Models;

namespace Decorator.StarbuzzCoffee.Beverages
{
    public class Expresso: Beverage
    {
        public Expresso(Size size)
        {
            Description = "Expresso";
            Size = size;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            double cost = 0;
            if (Size == Size.Tall)
            {
                cost += 0.10;
            }
            else if (Size == Size.Grande)
            {
                cost += 0.20;
            }
            else if (Size == Size.Venti)
            {
                cost += 0.30;
            }

            return cost + 1.99;
        }
    }
}
