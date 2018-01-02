namespace Command
{
    public class GarageDoorOpenCommand : ICommand
    {
        public void Execute()
        {
            this.garageDoor.Up();
            this.garageDoor.LightOn();
        }

        public void Undo()
        {
            this.garageDoor.Down();
            this.garageDoor.LightOff();
        }

        private GarageDoor garageDoor;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
    }
}
