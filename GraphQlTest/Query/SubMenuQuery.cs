using GraphQL;
using GraphQL.Types;
using GraphQlTest.Interfaces;
using GraphQlTest.Type;

namespace GraphQlTest.Query;

public class SubMenuQuery : ObjectGraphType
{
    public SubMenuQuery(ISubMenu subMenuService)
    {
        Field<ListGraphType<SubMenuType>>("subMenus",
            resolve: _ => subMenuService.GetSubMenus());

        Field<ListGraphType<SubMenuType>>("subMenuById", arguments: new QueryArguments
        {
            new QueryArgument<IntGraphType> {Name = "id"}
        }, resolve: context => subMenuService.GetSubMenus(context.GetArgument<int>("id")));
    }
}