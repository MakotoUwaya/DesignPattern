using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.NY
{
    public class NYStyleCheesePizza : PizzaBase
    {
        public override string Name => "ニューヨークスタイルのソース＆チーズピザ";

        public override string Dough => "薄いクラスト生地";

        public override string Sauce => "マリナラソース";

        public override IEnumerable<string> Toppings => new[] { "粉レッジャーノチーズ" };
    }
}
