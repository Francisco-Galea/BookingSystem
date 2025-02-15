using Booking.Models.Dao.ConnectionString;
using Booking.Models.Entities;

namespace Booking.Models.Dao.BookingDao
{
    public class BookingDaoSQLSERVER : IBookingDao
    {
        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void CreateBooking(BookingEntity booking)
        {
            throw new NotImplementedException();
        }

        public void DeleteBooking(int BookingId)
        {
            throw new NotImplementedException();
        }

        public List<BookingEntity> GetAllBookings()
        {
            throw new NotImplementedException();
        }

        public BookingEntity GetBookingById(int BookingId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBooking(int BookingId, BookingEntity booking)
        {
            throw new NotImplementedException();
        }
    }
}