using System;
using System.Collections.Generic;
using System.Text;

namespace Command.RemoteControl.Models
{
    public class CeilingFan
    {
        public static int High = 3;
        public static int Medium = 2;
        public static int Low = 1;
        public static int Off = 0;

        public string Name { get; }
        public int Speed { get; private set; }

        public CeilingFan(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public void SetHigh()
        {
            Speed = High;
            Console.WriteLine($"Ceiling Fan speed from {Name} set to high");
        }

        public void SetMedium()
        {
            Speed = Medium;
            Console.WriteLine($"Ceiling Fan speed from {Name} set to medium");
        }

        public void SetLow()
        {
            Speed = Low;
            Console.WriteLine($"Ceiling Fan speed from {Name} set to low");
        }

        public void SetOff()
        {
            Speed = Off;
            Console.WriteLine($"Ceiling Fan speed from {Name} set off");
        }
    }
}