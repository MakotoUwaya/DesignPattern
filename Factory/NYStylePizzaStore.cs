﻿using Factory.Model.PIzza.NY;

namespace Factory
{
    public class NYStylePizzaStore : PizzaStoreBase
    {
        protected override PizzaBase CreatePizza(string pizzaType)
        {
            switch (pizzaType.ToLower())
            {
                case "cheese":
                    return new NYStyleCheesePizza();
                case "veggie":
                    return new NYStyleVeggiePizza();
                case "clam":
                    return new NYStyleClamPizza();
                case "pepperroni":
                    return new NYStylePepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
