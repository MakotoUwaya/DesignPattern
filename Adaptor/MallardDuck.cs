using System;

namespace Adaptor
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("飛んでいます");
        }

        public void Quack()
        {
            Console.WriteLine("ガーガー");
        }
    }
}
