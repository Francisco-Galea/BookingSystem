namespace Booking.Dtos.BookedEntities
{
    public class BookingPropertyDTO : BookingBaseDTO
    {

        #pragma warning disable CS8618 
        public string Location { get; set; }
        public string description { get; set; }

        #pragma warning restore CS8618

    }
}
