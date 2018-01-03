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
            Console.WriteLine("メニュー");
            Console.WriteLine("-----------");
            foreach (var menu in this.menus)
            {
                menu.Print();
            }
        }
    }
}
