using System;

namespace TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("レモンを追加します");
        }

        protected override void Brew()
        {
            Console.WriteLine("紅茶を浸します");
        }
    }
}
