using Booking.Models.Entities;

namespace Boocking.Models.Factory.Interfaces
{
    public interface IHouseHoldApplianceFactory
    {
        RentableEntity CreateHouseHoldAppliance(string BRAND, string MODEL, string SERIALNUMBER, string USAGETYPE, string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY);
    }
}
