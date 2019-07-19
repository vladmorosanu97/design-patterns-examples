using System;
using System.Collections.Generic;
using System.Text;
using State.GumballMachines.Machines;

namespace State.GumballMachines.States
{
    public class HasQuarterState: IState
    {
        private GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned");
            _gumballMachine.SetState(_gumballMachine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
