namespace Command
{
    public class GarageDoorCloseCommand : ICommand
    {
        public void Execute()
        {
            this.garageDoor.Down();
            this.garageDoor.LightOff();
        }

        public void Undo()
        {
            this.garageDoor.Up();
            this.garageDoor.LightOn();
        }

        private GarageDoor garageDoor;
        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
    }
}
