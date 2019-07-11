using System;
using System.Collections.Generic;
using System.Text;

namespace Command.RemoteControl.Commands
{
    public class NoCommand: ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Nothing happened");
        }

        public void Undo()
        {
            Console.WriteLine("Nothing happened");
        }
    }
}
