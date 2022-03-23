using GraphQL.Types;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;
using GraphQlTest.Type;

namespace GraphQlTest.Query
{
    public class MenuQuery : ObjectGraphType
    {
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("menu", 
                resolve: context =>
            {
                return menuService.GetMenus();
            });
        }
    }
}
