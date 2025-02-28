using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Factory.Interface;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class ElectronicFactory : IElectronicFactory
    {
        public ElectronicEntity CreateElectronicEntity()
        {
            return new ElectronicEntity();
        }
    }
}
