using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class HouseholdApplianceFactory : IHouseHoldApplianceFactory
    {
        public RentableEntity CreateHouseHoldAppliance(string BRAND, string MODEL, string SERIALNUMBER, string USAGETYPE, string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY)
        {
            return new HouseholdApplianceEntity(BRAND, MODEL, SERIALNUMBER, USAGETYPE, NAME, DESCRIPTION, COSTUSAGERPERDAY);
        }
    }
}
