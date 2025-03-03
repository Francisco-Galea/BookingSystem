using Boocking.Models.Entities;

namespace Booking.Dtos.CoreDataBooking
{

    /// <summary>
    /// This DTO class is used in the UpdateBookingView. 
    /// What I do is retrieve this data from the Bookings and Clients tables 
    /// to show the system user which data they are about to modify when updating a booking.
    /// </summary>
    
    public class BookingCoreDataDto
    {
        public DateTime initBooking {  get; set; }
        public DateTime endBooking { get; set; }

        #pragma warning disable CS8618 
        public string paymentMethod { get; set; }
        #pragma warning restore CS8618 
        
        public bool isPaid { get; set; }

        #pragma warning disable CS8618 
        public ClientEntity oClient { get; set; }
        #pragma warning restore CS8618 

    }
}
