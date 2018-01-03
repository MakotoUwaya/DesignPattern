using System.Collections.Generic;

namespace Iterator
{
    public class DinerMenu : Menu
    {
        public DinerMenu() : base("食堂メニュー","昼食", new List<MenuComponentBase>
        {
            new MenuItem("ベジタリアンBLT", "レタス、トマト、(偽)ベーコンをはさんだ全粒小麦パンサンドイッチ", true, 2.99),
            new MenuItem("BLT", "レタス、トマト、ベーコンをはさんだ全粒小麦パンサンドイッチ", false, 2.99),
            new MenuItem("本日のスープ", "ポテトサラダを添えた本日のスープ", false, 3.29),
            new MenuItem("Hotdog", "ザワークラウト、レリッシュ、玉ねぎ、チーズをはさんだホットドック", false, 3.05),
        })
        {      
        }
    }
}
