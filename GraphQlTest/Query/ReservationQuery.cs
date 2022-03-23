using GraphQL.Types;
using GraphQlTest.Interfaces;
using GraphQlTest.Type;

namespace GraphQlTest.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations", resolve: context =>
            {
                return reservationService.GetReservations();
            });
        }
    }
}
