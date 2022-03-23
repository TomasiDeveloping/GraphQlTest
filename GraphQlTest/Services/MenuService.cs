using GraphQlTest.Data;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;

namespace GraphQlTest.Services
{
    public class MenuService : IMenu
    {
        private readonly GraphQlDbContext _dbContext;

        public MenuService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Menu> GetMenus()
        {
            return _dbContext.Menus.ToList();
        }

        public Menu AdMenu(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }
    }
}

