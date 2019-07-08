using System;
using System.Collections.Generic;
using System.Text;

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
