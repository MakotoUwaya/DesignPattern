using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.Chicago
{
    public class ChicagoStyleCheesePizza : PizzaBase
    {
        public override string Name => "シカゴスタイルのディープディッシュチーズピザ";

        public override string Dough => "極厚クラスト生地";

        public override string Sauce => "プラムトマトソース";

        public override IEnumerable<string> Toppings => new[] { "刻んだモッツアレラチーズ" };
    }
}
