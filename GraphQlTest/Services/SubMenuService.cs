using GraphQlTest.Data;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;

namespace GraphQlTest.Services
{
    public class SubMenuService :ISubMenu
    {
        private readonly GraphQlDbContext _dbContext;

        public SubMenuService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SubMenu> GetSubMenus()
        {
            return _dbContext.SubMenus.ToList();
        }

        public List<SubMenu> GetSubMenus(int menuId)
        {
            return _dbContext.SubMenus.Where(s => s.MenuId == menuId).ToList();
        }

        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            _dbContext.SubMenus.Add(subMenu);
            _dbContext.SaveChanges();
            return subMenu;
        }
    }
}
