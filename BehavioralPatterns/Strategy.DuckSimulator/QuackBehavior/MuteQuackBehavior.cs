using System;

namespace Strategy.DuckSimulator.QuackBehavior
{
    public class MuteQuackBehavior: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
