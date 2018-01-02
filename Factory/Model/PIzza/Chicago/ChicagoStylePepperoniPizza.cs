using System;
using System.Collections.Generic;

namespace Factory.Model.PIzza.Chicago
{
    public class ChicagoStylePepperoniPizza : PizzaBase
    {
        public override string Name => "ChicagoStylePepperoniPizza";
        public ChicagoStylePepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {

        }
    }
}
