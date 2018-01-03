using System;
using System.Collections.Generic;

namespace Iterator
{
    public class Waitress
    {
        private IEnumerable<IMenu> menuList;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            this.menuList = new List<IMenu>
            {
                pancakeHouseMenu,
                dinerMenu,
            };
        }

        public void PrintMenu()
        {
            Console.WriteLine("メニュー");
            Console.WriteLine("----------");
            foreach (var menu in this.menuList)
            {
                this.PrintMenu(menu.GetMenuItems());
            }
        }

        private void PrintMenu(IEnumerable<MenuItem> menuItems)
        {
            foreach (var item in menuItems)
            {
                Console.WriteLine($"{item.Name}、{item.Price} -- {item.Description}");
            }
        }
    }


}
