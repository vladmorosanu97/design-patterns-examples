using System;
using System.Collections.Generic;
using System.Text;

namespace State.GumballMachines.States
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
