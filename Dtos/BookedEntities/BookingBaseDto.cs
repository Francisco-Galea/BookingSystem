using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Dtos.BookedEntities
{
    public class BookingBaseDTO
    {
        public int bookingId { get; set; } //
        public DateTime initBooking { get; set; } //
        public DateTime endBooking { get; set; } //
        public int daysBooked { get; set; } //
        public string paymentMethod { get; set; }
        public decimal totalPrice { get; set; } //
        public bool isPaid { get; set; }
        public int rentableId { get; set; } //
        public string rentableName { get; set; } //

    }
}
