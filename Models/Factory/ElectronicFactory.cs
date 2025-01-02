using Booking.Models.Entities;
using Booking.Models.Factory.Interface;

namespace Booking.Models.Factory
{
    public class ElectronicFactory : IFactoryRentable
    {
        public RentableEntity CreateORentable()
        {
            throw new NotImplementedException();
        }
    }
}
