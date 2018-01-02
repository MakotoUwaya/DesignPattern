using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.NY
{
    public class NYStyleCheesePizza : PizzaBase
    {
        public NYStyleCheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
        }       

        public override string Name => "ニューヨークスタイルのソース＆チーズピザ";

    }
}
