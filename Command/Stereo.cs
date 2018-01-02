using System;

namespace Command
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("ステレオが再生されています");
        }

        public void Off()
        {
            Console.WriteLine("ステレオが停止しています");
        }

        public void SetCd()
        {
            Console.WriteLine("CDが選択されています");
        }

        public void SetDvd()
        {
            Console.WriteLine("DVDが選択されています");
        }

        public void SetRadio()
        {
            Console.WriteLine("ラジオが選択されています");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"ボリュームが{volume}にセットされています");
        }

    }
}
