using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.NY
{
    public class NYStyleVeggiePizza : PizzaBase
    {
        public override string Name => "NYStyleVeggiePizza";

        public NYStyleVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
        }
    }
}
