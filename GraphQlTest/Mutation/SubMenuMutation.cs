using GraphQL;
using GraphQL.Types;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;
using GraphQlTest.Type;

namespace GraphQlTest.Mutation
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubMenu",
                arguments: new QueryArguments(new QueryArgument<SubMenuInputType> {Name = "subMenu"}), 
                resolve: context =>
                {
                    return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu"));
                });
        }
    }
}
