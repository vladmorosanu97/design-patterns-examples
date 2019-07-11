using System;
using System.Collections.Generic;
using System.Text;

namespace Command.RemoteControl.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
