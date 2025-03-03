using Boocking.Models.Entities;

namespace Booking.Dtos.BookedEntities
{

    /// <summary>
    /// This class and its inheritances 
    /// retrieve the most important information about the booking and display it to the user in the  
    /// <see cref="BookingsHistoricalView"/> 
    /// </summary>

    public class BookingBaseDTO
    {
        public int bookingId { get; set; } 

        public DateTime initBooking { get; set; } 

        public DateTime endBooking { get; set; }

        #pragma warning disable CS8618 
        public ClientEntity oClient {  get; set; }

        public int daysBooked { get; set; } 

        public string paymentMethod { get; set; }

        public decimal totalPrice { get; set; } 

        public bool isPaid { get; set; }

        public int rentableId { get; set; } 

        public string rentableName { get; set; }
        #pragma warning restore CS8618 

    }
}
