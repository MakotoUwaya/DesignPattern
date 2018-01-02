
using System;

namespace Adaptor
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("短い距離を飛んでいます");
        }

        public void Gobble()
        {
            Console.WriteLine("ゴロゴロ");
        }
    }
}
