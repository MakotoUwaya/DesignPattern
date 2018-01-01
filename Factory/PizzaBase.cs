using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class PizzaBase
    {
        public abstract string Name { get; }
        public abstract string Dough { get; }
        public abstract string Sauce { get; }
        public abstract IEnumerable<string> Toppings { get; }
        public virtual void Prepare()
        {
            Console.WriteLine($"{this.Name}を下処理");
            Console.WriteLine("生地をこねる・・・・・・");
            Console.WriteLine("ソースを追加・・・・・・");
            Console.WriteLine($"トッピングを追加:{string.Join(",", this.Toppings)}");
        }
        public virtual void Bake()
        {
            Console.WriteLine("350度で25分間焼く");
        }
        public virtual void Cut()
        {
            Console.WriteLine("ピザを扇型に切り分ける");
        }
        public virtual void Box()
        {
            Console.WriteLine("PizzaStoreの正式な箱にピザを入れる");
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
