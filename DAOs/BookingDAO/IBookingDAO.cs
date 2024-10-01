using SistemaReservas.Models;

namespace SistemaReservas.DAOs.BookingDAO
{
    public interface IBookingDAO
    {
        void CreateBooking();
        void UpdateBooking(int BookingId, Booking booking);
        Booking GetBookingById(int BookingId);
        List<Booking> GetAllBookings();
        void DeleteBooking(int BookingId);
    }
}
