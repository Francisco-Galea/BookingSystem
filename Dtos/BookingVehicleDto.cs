
namespace Booking.Dtos
{
    public class BookingVehicleDTO : BookingBaseDTO
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int passengerCapacity { get; set; }
        public string serialNumber { get; set; }
    }
}
