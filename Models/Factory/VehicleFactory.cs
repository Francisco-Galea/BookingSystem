using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class VehicleFactory : IVehicleProperty
    {
        public RentableEntity CreateVehicleEntity(string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY, string BRAND, string MODEL, int PASSENGERCAPACITY, int SERIALNUMBER)
        {
            return new VehicleEntity(NAME, DESCRIPTION, COSTUSAGEPERDAY, BRAND, MODEL, PASSENGERCAPACITY, SERIALNUMBER);
        }
    }
}
