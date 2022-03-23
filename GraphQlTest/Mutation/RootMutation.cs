using GraphQL.Types;

namespace GraphQlTest.Mutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutation", resolve: _ => new {});
            Field<SubMenuMutation>("subMenuMutation", resolve: _ => new { });
            Field<ReservationMutation>("reservationMutation", resolve: _ => new { });
        }
    }
}
