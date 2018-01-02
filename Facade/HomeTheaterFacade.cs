using System;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private Tuner tuner;
        private CdPlayer cdPlayer;
        private DvdPlayer dvdPlayer;
        private TheaterLights theaterLights;
        private Screen screen;
        private PopcornPopper popcornPopper;

        public HomeTheaterFacade(Amplifier amp, Tuner tuner, CdPlayer cdPlayer, DvdPlayer dvdPlayer, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            this.amplifier = amp;
            this.tuner = tuner;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.theaterLights = lights;
            this.screen = screen;
            this.popcornPopper = popper;
        }

        public void WatchMovie()
        {
            Console.WriteLine("映画を見る準備をします.....");
            this.popcornPopper.On();
            this.popcornPopper.Pop();
            this.theaterLights.Dim();
            this.screen.Off();
            this.dvdPlayer.Projector.On();
            this.dvdPlayer.Projector.WideScreenMode();
            this.amplifier.On();
            this.amplifier.SetDvd();
            this.amplifier.SetSurroundSound();
            this.amplifier.SetVolume();
            this.amplifier.DvdPlayer.On();
            this.amplifier.DvdPlayer.Play();
        }
    }
}
