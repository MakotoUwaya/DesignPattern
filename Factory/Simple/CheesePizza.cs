using System;
using System.Collections.Generic;

namespace Factory.Simple
{
    public class CheesePizza : PizzaBase
    {
        public override string Name => "CheesePizza";

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
        }

    }
}
