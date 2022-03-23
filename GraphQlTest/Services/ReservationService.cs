using GraphQlTest.Data;
using GraphQlTest.Interfaces;
using GraphQlTest.Models;

namespace GraphQlTest.Services
{
    public class ReservationService : IReservation
    {
        private readonly GraphQlDbContext _dbContext;

        public ReservationService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList();
        }

        public Reservation AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return reservation;
        }
    }
}
