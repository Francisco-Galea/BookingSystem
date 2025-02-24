using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Dtos.CoreDataBooking
{
    public class BookingCoreDataDto
    {
        public DateTime initBooking {  get; set; }
        public DateTime endBooking { get; set; }
        public string paymentMethod { get; set; }
        public bool isPaid { get; set; }
        public string ClientName { get; set; }
        public string LastName {  get; set; }
        public string PhoneNumber { get; set; }

    }
}
