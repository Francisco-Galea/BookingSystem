using Booking.Models.Entities;

namespace Boocking.Models.Factory.Interfaces
{
    public interface VehicleProperty
    {
        RentableEntity CreateVehicleEntity(string BRAND, string MODEL, int PASSENGERCAPACITY, int SERIALNUMBER, string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY);
    }
}
