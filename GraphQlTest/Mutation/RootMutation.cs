using GraphQL.Types;

namespace GraphQlTest.Mutation
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutation", resolve: context => new {});
            Field<SubMenuMutation>("subMenuMutation", resolve: context => new { });
            Field<ReservationMutation>("reservationMutation", resolve: context => new { });
        }
    }
}
