using System;
using System.Collections.Generic;
using System.Text;
using Strategy.DuckSimulator.FlyBehavior;
using Strategy.DuckSimulator.QuackBehavior;

namespace Strategy.DuckSimulator.Client
{
    public abstract class Duck
    {
        private readonly IFlyBehavior _flyBehavior;
        private readonly IQuackBehavior _quackBehavior;

        protected Duck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            _quackBehavior = quackBehavior;
            _flyBehavior = flyBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }
    }
}
