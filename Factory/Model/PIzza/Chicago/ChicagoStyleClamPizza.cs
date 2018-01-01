using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.Chicago
{
    public class ChicagoStyleClamPizza : PizzaBase
    {
        public override string Name => "ChicagoStyleClamPizza";

        public ChicagoStyleClamPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {

        }
    }
}
