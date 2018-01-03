using System;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        public Coffee(bool isCondiments)
        {
            this.CustmerWantsCondiments = isCondiments;
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("砂糖とミルクを追加します");
        }

        protected override void Brew()
        {
            Console.WriteLine("フィルタでコーヒーをドリップします");
        }
    }
}
