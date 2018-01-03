using System;
using System.Collections.Generic;

namespace Iterator
{
    public class Menu : MenuComponentBase
    {
        private IList<MenuComponentBase> menuItems;

        public override string Name { get; }

        public override string Description { get; }

        public override double Price => throw new NotImplementedException();

        public override bool Vegetarian => throw new NotImplementedException();

        public Menu(string name, string description) : this(name, description, null)
        {
        }

        public Menu(string name, string description, IList<MenuComponentBase> menus)
        {
            this.Name = name;
            this.Description = description;
            this.menuItems = menus ?? new List<MenuComponentBase>();
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            this.Add(new MenuItem(name, description, vegetarian, price));
        }

        public override void Add(MenuComponentBase item)
        {
            this.menuItems.Add(item);
        }
        public override void Remove(MenuComponentBase menuComponent)
        {
            this.menuItems.Remove(menuComponent);
        }

        public override MenuComponentBase GetChild(int index)
        {
            if (index < 0 || this.menuItems.Count <= index)
            {
                return null;
            }
            return this.menuItems[index];
        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"{this.Name}、{this.Description}");
            Console.WriteLine("-----------");
            foreach (var item in this.menuItems)
            {
                item.Print();
            }
        }

        public override void ConditionalPrint(Func<MenuItem, bool> condition)
        {
            foreach (var item in this.menuItems)
            {
                item.ConditionalPrint(condition);
            }
        }
    }
}
