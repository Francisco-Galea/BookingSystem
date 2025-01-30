using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Factory.Interface;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class ElectronicFactory : IElectronicFactory
    {
        public RentableEntity CreateElectronicEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string BRAND, string MODEL, string SERIALNUMBER)
        {
            return new ElectronicEntity(BRAND, MODEL, SERIALNUMBER, NAME, DESCRIPTION, COSTUSAGERPERDAY);
        }
    }
}
