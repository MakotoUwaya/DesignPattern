using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.Chicago
{
    public class ChicagoStyleVeggiePizza : PizzaBase
    {
        public override string Name => "ChicagoStyleVeggiePizza";

        public ChicagoStyleVeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {

        }
    }
}
