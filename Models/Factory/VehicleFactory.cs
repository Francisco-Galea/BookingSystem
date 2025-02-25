using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class VehicleFactory : IVehicleFactory
    {
        public VehicleEntity CreateVehicleEntity()
        {
            return new VehicleEntity();
        }
    }
}
