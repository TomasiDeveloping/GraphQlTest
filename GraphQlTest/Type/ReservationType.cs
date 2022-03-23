using GraphQL.Types;
using GraphQlTest.Models;

namespace GraphQlTest.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(r => r.Id);
            Field(r => r.Name);
            Field(r => r.Phone);
            Field(r => r.TotalPeople);
            Field(r => r.Email);
            Field(r => r.Date);
            Field(r => r.Time);
        }
    }
}
