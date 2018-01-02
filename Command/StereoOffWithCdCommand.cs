namespace Command
{
    public class StereoOffWithCdCommand : ICommand
    {
        public void Execute()
        {
            this.stereo.SetCd();
            this.stereo.SetVolume(0);
            this.stereo.Off();
        }

        public void Undo()
        {
            this.stereo.SetVolume(11);
            this.stereo.On();
        }

        private Stereo stereo;
        public StereoOffWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
    }
}
