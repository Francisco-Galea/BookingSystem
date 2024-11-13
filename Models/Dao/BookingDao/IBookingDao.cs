using Booking.Models.Entities;

namespace Booking.Models.Dao.BookingDao
{
    public interface IBookingDao
    {
        void CreateBooking();
        void UpdateBooking(int BookingId, BookingEntity booking);
        BookingEntity GetBookingById(int BookingId);
        List<BookingEntity> GetAllBookings();
        void DeleteBooking(int BookingId);
    }
}
