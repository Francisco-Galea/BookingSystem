using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class HouseholdApplianceFactory : IHouseHoldApplianceFactory
    {
        public RentableEntity CreateHouseHoldAppliance(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string BRAND, string MODEL, string SERIALNUMBER, string USAGETYPE)
        {
            return new HouseholdApplianceEntity(NAME, DESCRIPTION, COSTUSAGERPERDAY, BRAND, MODEL, SERIALNUMBER, USAGETYPE);
        }
    }
}
