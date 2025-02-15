using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class VehicleFactory : IVehicleFactory
    {
        public RentableEntity CreateVehicleEntity(string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY, string BRAND, string MODEL, int PASSENGERCAPACITY, string SERIALNUMBER)
        {
            return new VehicleEntity(NAME, DESCRIPTION, COSTUSAGEPERDAY, BRAND, MODEL, PASSENGERCAPACITY, SERIALNUMBER);
        }
    }
}
