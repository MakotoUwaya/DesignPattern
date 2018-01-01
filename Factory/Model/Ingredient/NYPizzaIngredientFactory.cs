using System.Collections.Generic;

namespace Factory.Model.Ingredient
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new NYCheese();
        }

        public IClams CreateClams()
        {
            return new NYClam();
        }

        public IDough CreateDough()
        {
            return new NYDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new NYNYPepperoni();
        }

        public ISouce CreateSouce()
        {
            return new NYSouce();
        }

        public IEnumerable<IVeggies> CreateVeggies()
        {
            return new List<IVeggies> { new NYApple(), new NYEggplant() };
        }
    }
}
