using System.Collections.Generic;
using Command.RemoteControl.Commands;

namespace Command.RemoteControl.RemoteControls
{
    public class RemoteControlWithUndo
    {
        private List<ICommand> _onCommands;
        private List<ICommand> _offCommands;
        private ICommand _undoCommand;
        public int Slots { get; } = 7;

        public RemoteControlWithUndo()
        {
            _onCommands = new List<ICommand>();
            _offCommands = new List<ICommand>();


            ICommand noCommand = new NoCommand();

            for (int i = 0; i < Slots; i++)
            {
                _onCommands.Add(noCommand);
                _offCommands.Add(noCommand);
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }
    }
}
