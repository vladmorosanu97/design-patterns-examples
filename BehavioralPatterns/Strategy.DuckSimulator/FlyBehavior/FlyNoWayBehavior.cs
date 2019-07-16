using System;

namespace Strategy.DuckSimulator.FlyBehavior
{
    public class FlyNoWayBehavior: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
