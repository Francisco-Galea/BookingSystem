using Booking.Models.Entities;

namespace Boocking.Models.Factory.Interfaces
{
    public interface IVehicleFactory
    {
        RentableEntity CreateVehicleEntity(string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY, string BRAND, string MODEL, int PASSENGERCAPACITY, string SERIALNUMBER);
    }
}
