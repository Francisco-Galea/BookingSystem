
using Booking.Models.Entities;
using Booking.Models.Factory.Interface;

namespace Booking.Models.Factory
{
    public class ElectronicFactory : IFactoryRentable
    {
        public RentableEntity CreateORentable(string NAME, string DESCRIPTION, decimal MAINTENANCECOSTPERDAY, decimal COSTUSAGERPERDAY)
        {
            throw new NotImplementedException();
        }
    }
}
