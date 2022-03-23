using GraphQL;
using GraphQL.Types;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;
using GraphQlTest.Type;

namespace GraphQlTest.Mutation
{
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservation reservationService)
        {
            Field<ReservationType>("createReservation",
                arguments: new QueryArguments(new QueryArgument<ReservationInputType> {Name = "reservation"}), 
                resolve: context =>
                {
                    return reservationService.AddReservation(context.GetArgument<Reservation>("reservation"));
                });
        }
    }
}
