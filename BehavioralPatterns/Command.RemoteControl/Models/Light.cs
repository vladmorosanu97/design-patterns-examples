using System;

namespace Command.RemoteControl.Models
{
    public class Light
    {
        public Light(bool status, string name)
        {
            Status = status;
            Name = name;
        }

        public bool Status { get; private set; }
        public string Name { get; }

        public void On()
        {
            Status = true;
            Console.WriteLine($"Light from {Name} is on");
        }

        public void Off()
        {
            Status = false;
            Console.WriteLine($"Light from {Name} is off");
        }
    }
}
