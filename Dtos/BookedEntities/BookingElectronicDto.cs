
using System.Security.Policy;

namespace Booking.Dtos.BookedEntities
{
    public class BookingElectronicDto : BookingBaseDTO
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string serialNumber { get; set; }

    }
}
