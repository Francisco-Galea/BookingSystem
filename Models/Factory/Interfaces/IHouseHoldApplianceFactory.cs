using Booking.Models.Entities;

namespace Boocking.Models.Factory.Interfaces
{
    public interface IHouseHoldApplianceFactory
    {
        RentableEntity CreateHouseHoldAppliance(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string BRAND, string MODEL, string SERIALNUMBER, string USAGETYPE);
    }
}
