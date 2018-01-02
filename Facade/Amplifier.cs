using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Amplifier
    {
        public Tuner Tuner { get; private set; }
        public CdPlayer CdPlayer { get; private set; }
        public DvdPlayer DvdPlayer { get; private set; }

        public Amplifier(Tuner tuner, CdPlayer cdPlayer, DvdPlayer dvdPlayer)
        {
            this.Tuner = tuner;
            this.CdPlayer = cdPlayer;
            this.DvdPlayer = dvdPlayer;
        }

        public void On()
        {

        }

        public void Off()
        {

        }

        public void SetSurroundSound()
        {

        }

        public void SetVolume()
        {

        }

        public void SetDvd()
        {

        }
    }

}
