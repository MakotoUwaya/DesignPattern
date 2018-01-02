using System;

namespace Facade
{
    public class DvdPlayer
    {
        private Amplifier amplifier;
        public Projector Projector { get; private set; }

        public DvdPlayer(Projector projector)
        {
            this.Projector = projector;
        }

        public void On()
        {
            Console.WriteLine("");
        }

        public void Off()
        {
            Console.WriteLine("");
        }

        public void Eject()
        {
            Console.WriteLine("");
        }

        public void Pause()
        {
            Console.WriteLine("");
        }
    
        public void Play()
        {
            Console.WriteLine("");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("");
        }

        public void Stop()
        {
            Console.WriteLine("");
        }
    }
}
