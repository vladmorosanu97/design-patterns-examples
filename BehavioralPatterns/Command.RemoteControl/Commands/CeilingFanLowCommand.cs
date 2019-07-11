using System;
using System.Collections.Generic;
using System.Text;
using Command.RemoteControl.Models;

namespace Command.RemoteControl.Commands
{
    public class CeilingFanLowCommand: ICommand
    {
        private readonly CeilingFan _ceilingFan;
        private int _prevSpeed;
        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
            _prevSpeed = _ceilingFan.Speed;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.SetLow();
        }

        public void Undo()
        {
            if (_prevSpeed == CeilingFan.High)
            {
                _ceilingFan.SetHigh();
            }
            else if (_prevSpeed == CeilingFan.Medium)
            {
                _ceilingFan.SetMedium();
            }
            else if (_prevSpeed == CeilingFan.Low)
            {
                _ceilingFan.SetLow();
            }
            else if (_prevSpeed == CeilingFan.Off)
            {
                _ceilingFan.SetOff();
            }
        }
    }
}
