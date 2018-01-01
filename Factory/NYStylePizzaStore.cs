using Factory.Model.PIzza.NY;

namespace Factory
{
    public class NYStylePizzaStore : PizzaStoreBase
    {
        private IPizzaIngredientFactory pizzaIngredientFactory;

        public NYStylePizzaStore(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
        }

        protected override PizzaBase CreatePizza(string pizzaType)
        {
            switch (pizzaType.ToLower())
            {
                case "cheese":
                    return new NYStyleCheesePizza(this.pizzaIngredientFactory);
                case "veggie":
                    return new NYStyleVeggiePizza(this.pizzaIngredientFactory);
                case "clam":
                    return new NYStyleClamPizza(this.pizzaIngredientFactory);
                case "pepperroni":
                    return new NYStylePepperoniPizza(this.pizzaIngredientFactory);
                default:
                    return null;
            }
        }
    }
}
