namespace Command
{
    public class StereoOnWithCdCommand : ICommand
    {
        public void Execute()
        {
            this.stereo.SetCd();
            this.stereo.On();
            this.stereo.SetVolume(11);
        }

        public void Undo()
        {
            this.stereo.SetVolume(0);
            this.stereo.Off();
        }

        private Stereo stereo;
        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
    }
}
