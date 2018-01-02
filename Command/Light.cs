using System;

namespace Command
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("照明が点灯しています...");
        }

        public void Off()
        {
            Console.WriteLine("照明が消灯しています...");
        }
    }
}
