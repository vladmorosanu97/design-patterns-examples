using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.DuckSimulator.FlyBehavior
{
    public class FlyBehavior: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
