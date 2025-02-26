namespace Booking.Dtos.BookedEntities
{
    public class BookingVehicleDTO : BookingBaseDTO
    {

        #pragma warning disable CS8618 
        public string brand { get; set; }

        public string model { get; set; }

        public string serialNumber { get; set; }
        #pragma warning restore CS8618

    }
}
