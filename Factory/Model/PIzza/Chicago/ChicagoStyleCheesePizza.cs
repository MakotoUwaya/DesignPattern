using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.Chicago
{
    public class ChicagoStyleCheesePizza : PizzaBase
    {
        public override string Name => "シカゴスタイルのディープディッシュチーズピザ";

        public ChicagoStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {

        }
    }
}
