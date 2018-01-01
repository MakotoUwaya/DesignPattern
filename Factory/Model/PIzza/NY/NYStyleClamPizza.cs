using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.NY
{
    public class NYStyleClamPizza : PizzaBase
    {
        public override string Name => "NYStyleClamPizza";

        public NYStyleClamPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
        }
    }
}
