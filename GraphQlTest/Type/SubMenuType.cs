using GraphQL.Types;
using GraphQlTest.Models;

namespace GraphQlTest.Type
{
    public sealed class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(sb => sb.Id);
            Field(sb => sb.Name);
            Field(sb => sb.Description);
            Field(sb => sb.ImageUrl);
            Field(sb => sb.Price);
            Field(sb => sb.MenuId);
        }
    }
}
