namespace Command
{
    public class LightOnCommand : ICommand
    {
        public void Execute()
        {
            this.light.On();
        }

        public void Undo()
        {
            this.light.Off();
        }

        private Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
    }
}
