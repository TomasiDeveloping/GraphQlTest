using GraphQlTest.Models;

namespace GraphQlTest.Interfaces
{
    public interface IReservation
    {
        List<Reservation> GetReservations();
        Reservation AddReservation(Reservation reservation);
    }
}
