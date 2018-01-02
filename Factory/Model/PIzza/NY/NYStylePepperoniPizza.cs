using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.NY
{
    public class NYStylePepperoniPizza : PizzaBase
    {
        public override string Name => "NYStylePepperoniPizza";

        public NYStylePepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
        }
    }
}
