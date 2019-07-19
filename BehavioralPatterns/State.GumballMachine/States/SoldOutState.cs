using System;
using System.Collections.Generic;
using System.Text;
using State.GumballMachines.Machines;

namespace State.GumballMachines.States
{
    public class SoldOutState: IState
    {
        private GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Cannot insert a quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("There isn't any quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You cannot turn crank");
        }

        public void Dispense()
        {
            Console.WriteLine("You cannot dispense");
        }
    }
}
