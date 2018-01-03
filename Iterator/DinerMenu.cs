using System.Collections.Generic;

namespace Iterator
{
    public class DinerMenu : IMenu
    {
        private MenuItem[] menuItems;

        public DinerMenu()
        {
            this.menuItems = new MenuItem[4];
            this.menuItems[0] = new MenuItem("ベジタリアンBLT", "レタス、トマト、(偽)ベーコンをはさんだ全粒小麦パンサンドイッチ", true, 2.99);
            this.menuItems[1] = new MenuItem("BLT", "レタス、トマト、ベーコンをはさんだ全粒小麦パンサンドイッチ", false, 2.99);
            this.menuItems[2] = new MenuItem("本日のスープ", "ポテトサラダを添えた本日のスープ", false, 3.29);
            this.menuItems[3] = new MenuItem("Hotdog", "ザワークラウト、レリッシュ、玉ねぎ、チーズをはさんだホットドック", false, 3.05);          
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var currentMenuItems = this.menuItems;
            this.menuItems =  new MenuItem[this.menuItems.Length + 1];
            for (var i = 0; i < currentMenuItems.Length; i++)
            {
                this.menuItems[i] = currentMenuItems[i];
            }

            this.menuItems[currentMenuItems.Length] = new MenuItem(name, description, vegetarian, price);
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            return this.menuItems;
        }
    }
}
