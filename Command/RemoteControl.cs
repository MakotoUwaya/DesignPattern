using System.Text;

namespace Command
{
    public class RemoteControl
    {
        private ICommand[] onCommand;
        private ICommand[] offCommand;
        private ICommand undoCommand;

        public RemoteControl()
        {
            this.onCommand = new ICommand[7];
            this.offCommand = new ICommand[7];

            for (var i = 0; i < 7; i++)
            {
                this.onCommand[i] = new NoCommand();
                this.offCommand[i] = new NoCommand();
            }
            this.undoCommand = new NoCommand();
        }

        private bool IsRange(int slot)
        {
            return 0 <= slot && slot < this.onCommand.Length && slot < this.offCommand.Length;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            if (!this.IsRange(slot))
            {
                return;
            }

            this.onCommand[slot] = onCommand;
            this.offCommand[slot] = offCommand;
        }

        public void OnButtonPushed(int slot)
        {
            if (!this.IsRange(slot))
            {
                return;
            }
            this.onCommand[slot].Execute();
            this.undoCommand = this.onCommand[slot];
        }

        public void OffButtonPushed(int slot)
        {
            if (!this.IsRange(slot))
            {
                return;
            }
            this.offCommand[slot].Execute();
            this.undoCommand = this.offCommand[slot];
        }


        public void UndoCommand()
        {
            this.undoCommand.Undo();
        }
        
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("----- リモコン -----");
            for (var i = 0; i < this.onCommand.Length; i++)
            {
                stringBuilder.AppendLine($"[slot {i}] {this.onCommand[i].GetType().Name} {this.offCommand[i].GetType().Name}");
            }
            return stringBuilder.ToString();
        }
    }
}
