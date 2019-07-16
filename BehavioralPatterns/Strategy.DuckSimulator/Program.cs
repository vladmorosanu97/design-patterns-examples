using Strategy.DuckSimulator.Client;
using Strategy.DuckSimulator.FlyBehavior;
using Strategy.DuckSimulator.QuackBehavior;

namespace Strategy.DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyBehavior flyBehavior = new FlyBehavior.FlyBehavior();
            IQuackBehavior quackBehavior = new QuackBehavior.QuackBehavior();

            MallardDuck mallardDuck = new MallardDuck(quackBehavior, flyBehavior);
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            IFlyBehavior flyBehaviorNoFly = new FlyNoWayBehavior();
            IQuackBehavior quackBehaviorNoQuack = new MuteQuackBehavior();

            MallardDuck mallardDuckSpecial = new MallardDuck(quackBehaviorNoQuack, flyBehaviorNoFly);
            mallardDuckSpecial.PerformFly();
            mallardDuckSpecial.PerformQuack();
        }
    }
}