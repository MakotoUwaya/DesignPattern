using System;

namespace Iterator
{
    public class MenuItem : MenuComponentBase
    {
        public override string Name { get; }

        public override string Description { get; }

        public override double Price { get; }

        public override bool Vegetarian { get; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Vegetarian = vegetarian;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public override void Print()
        {
            Console.WriteLine($"\t{this.Name}{this.VegetarianMark()}、{this.Price}\n\t-- {this.Description}");
        }

        public override void ConditionalPrint(Func<MenuItem, bool> condition)
        {
            if (condition == null || !condition(this))
            {
                return;
            }
            this.Print();
        }

        private string VegetarianMark()
        {
            return this.Vegetarian ? "(v)" : string.Empty;
        }
    }
}
