using System;
using Command.RemoteControl.Commands;
using Command.RemoteControl.Models;
using Command.RemoteControl.RemoteControls;

namespace Command.RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            Light livingRoomLight = new Light(false, "Living Room");
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);

            remoteControl.UndoButtonWasPushed();

            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room", CeilingFan.Off); 
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(livingRoomCeilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(livingRoomCeilingFan);
            remoteControl.SetCommand(1, ceilingFanHighCommand, ceilingFanOffCommand);
            remoteControl.SetCommand(2, ceilingFanLowCommand, ceilingFanOffCommand);

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();
        }
    }
}
