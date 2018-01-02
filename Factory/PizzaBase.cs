using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class PizzaBase
    {
        private IPizzaIngredientFactory pizzaIngredientFactory;

        public abstract string Name { get; }
        public string Dough { get; private set; }
        public string Sauce { get; private set; }
        public string Toppings { get; private set; }
        public string Cheese { get; private set; }
        public string Pepperoni { get; private set; }
        public string Clam { get; private set; }

        public PizzaBase(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.pizzaIngredientFactory = pizzaIngredientFactory;
            this.Dough = this.pizzaIngredientFactory.CreateDough().Name;
            this.Sauce = this.pizzaIngredientFactory.CreateSouce().Name;
            this.Toppings = string.Join(",", this.pizzaIngredientFactory.CreateVeggies());
            this.Cheese = this.pizzaIngredientFactory.CreateCheese().Name;
            this.Clam = this.pizzaIngredientFactory.CreateClams().Name;
            this.Pepperoni = this.pizzaIngredientFactory.CreatePepperoni().Name;
        }

        public virtual void Prepare()
        {
            Console.WriteLine($"{this.Name}を下処理");
            Console.WriteLine("生地をこねる・・・・・・");
            Console.WriteLine("ソースを追加・・・・・・");
            Console.WriteLine($"トッピングを追加:{string.Join(",", this.Toppings)}");
        }
        public virtual void Bake()
        {
            Console.WriteLine("350度で25分間焼く");
        }
        public virtual void Cut()
        {
            Console.WriteLine("ピザを扇型に切り分ける");
        }
        public virtual void Box()
        {
            Console.WriteLine("PizzaStoreの正式な箱にピザを入れる");
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
