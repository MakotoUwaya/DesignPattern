using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            this.menuItems = new List<MenuItem>
            {
                new MenuItem("K&Bのパンケーキ朝食", "スクランブルエッグとトーストが付いたパンケーキ", true, 2.99),
                new MenuItem("通常のパンケーキ朝食", "卵焼きとソーセージが付いたパンケーキ", false, 2.99),
                new MenuItem("ブルーベリーパンケーキ", "新鮮なブルーベリーで作ったパンケーキ", true, 3.49),
                new MenuItem("ワッフル", "ブルーベリーか苺の好きなほうをのせたワッフル", true, 3.59),
            };
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            this.menuItems.Add(new MenuItem(name, description, vegetarian, price));
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            return this.menuItems;
        }
    }
}
