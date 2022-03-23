using GraphQL.Types;

namespace GraphQlTest.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuQuery", resolve: _ => new { });
            Field<SubMenuQuery>("subMenuQuery", resolve: _ => new { });
            Field<ReservationQuery>("reservationQuery", resolve: _ => new { });
        }
    }
}
