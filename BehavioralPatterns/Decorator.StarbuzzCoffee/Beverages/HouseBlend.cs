﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.StarbuzzCoffee.Beverages
{
    public class HouseBlend: Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
