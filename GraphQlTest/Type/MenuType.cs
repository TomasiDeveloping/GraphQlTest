using GraphQL.Types;
using GraphQlTest.Models;

namespace GraphQlTest.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
        }
    }
}
