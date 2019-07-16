using System;

namespace Strategy.DuckSimulator.QuackBehavior
{
    public class QuackBehavior: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
