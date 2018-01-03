using System;
using System.Collections.Generic;

namespace Iterator
{
    public class Waitress
    {
        private IEnumerable<MenuComponentBase> menus;

        public Waitress(IEnumerable<MenuComponentBase> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("メニュー");
            Console.WriteLine("-----------");
            foreach (var menu in this.menus)
            {
                menu.Print();
            }
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine();
            Console.WriteLine("菜食メニュー");
            Console.WriteLine("-----------");
            foreach (var menu in this.menus)
            {
                menu.ConditionalPrint(m => m.Vegetarian);
            }
        }

        public void PrintValuePriceMenu()
        {
            Console.WriteLine();
            Console.WriteLine("安価なメニュー");
            Console.WriteLine("-----------");
            foreach (var menu in this.menus)
            {
                menu.ConditionalPrint(m => m.Price < 2.0);
            }
        }
    }
}
