﻿using GraphQL.Types;
using GraphQlTest.Models;

namespace GraphQlTest.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(sb => sb.Id);
            Field(sb => sb.Name);
            Field(sb => sb.Description);
            Field(sb => sb.IamgeUrl);
            Field(sb => sb.Price);
            Field(sb => sb.MenuId);
        }
    }
}
