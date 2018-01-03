using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenu : Menu
    {
        public PancakeHouseMenu() : base("パンケーキハウスメニュー", "朝食", new List<MenuComponentBase>
            {
                new MenuItem("K&Bのパンケーキ朝食", "スクランブルエッグとトーストが付いたパンケーキ", true, 2.99),
                new MenuItem("通常のパンケーキ朝食", "卵焼きとソーセージが付いたパンケーキ", false, 2.99),
                new MenuItem("ブルーベリーパンケーキ", "新鮮なブルーベリーで作ったパンケーキ", true, 3.49),
                new MenuItem("ワッフル", "ブルーベリーか苺の好きなほうをのせたワッフル", true, 3.59),
            })
        {
        }
    }
}
