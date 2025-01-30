using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class VehicleFactory : IVehicleProperty
    {
        public RentableEntity CreateVehicleEntity(string BRAND, string MODEL, int PASSENGERCAPACITY, int SERIALNUMBER, string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY)
        {
            return new VehicleEntity(BRAND, MODEL, PASSENGERCAPACITY, SERIALNUMBER, NAME, DESCRIPTION, COSTUSAGEPERDAY);
        }
    }
}
