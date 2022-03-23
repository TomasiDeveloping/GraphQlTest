using GraphQlTest.Models;

namespace GraphQlTest.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenus();
        Menu AdMenu(Menu menu);
    }
}
