using System;
using System.Collections.Generic;
using System.Text;
using State.GumballMachines.States;

namespace State.GumballMachines.Machines
{
    public class GumballMachine
    {
        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }

        public IState State { get; private set; }
        public int Count { get; private set; }
        public GumballMachine(int numberOfGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
        }

        public void SetState(IState state)
        {
            State = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot");
            if (Count > 0)
            {
                Count--;
            }
        }
    }
}