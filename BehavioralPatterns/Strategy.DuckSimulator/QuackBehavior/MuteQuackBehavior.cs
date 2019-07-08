using System;
using System.Collections.Generic;
using System.Text;

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
