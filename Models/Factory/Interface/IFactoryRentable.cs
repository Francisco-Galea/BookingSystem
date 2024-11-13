using Booking.Models.Entities;

namespace Booking.Models.Factory.Interface
{
    public interface IFactoryRentable
    {
        RentableEntity CreateORentable(string NAME, string DESCRIPTION, decimal MAINTENANCECOSTPERDAY, decimal COSTUSAGERPERDAY);
    }
}
