using GraphQL;
using GraphQL.Types;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;
using GraphQlTest.Type;

namespace GraphQlTest.Mutation
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            Field<MenuType>("createMenu", arguments: new QueryArguments(new QueryArgument<MenuInputType>
            {
                Name = "menu"
            }), resolve: context => menuService.AdMenu(context.GetArgument<Menu>("menu")));
        }
    }
}
