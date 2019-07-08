using System;
using System.Collections.Generic;
using System.Text;
using Strategy.DuckSimulator.FlyBehavior;
using Strategy.DuckSimulator.QuackBehavior;

namespace Strategy.DuckSimulator.Client
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior) : base(quackBehavior, flyBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}