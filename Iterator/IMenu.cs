using System.Collections.Generic;

namespace Iterator
{
    public interface IMenu
    {
        IEnumerable<MenuItem> GetMenuItems();
    }
}
