namespace Command
{
    public class LightOffCommand : ICommand
    {
        public void Execute()
        {
            this.light.Off();
        }

        public void Undo()
        {
            this.light.On();
        }

        private Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
    }
}
