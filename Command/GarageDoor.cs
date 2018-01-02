using System;

namespace Command
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("ガレージのドアが開いています");
        }

        public void Down()
        {
            Console.WriteLine("ガレージのドアが閉じています");
        }

        public void Stop()
        {
            Console.WriteLine("ガレージのドアが一時停止しています");
        }

        public void LightOn()
        {
            Console.WriteLine("ガレージの照明が点灯しています");
        }

        public void LightOff()
        {
            Console.WriteLine("ガレージの照明が消灯しています");
        }
    
    }
}
