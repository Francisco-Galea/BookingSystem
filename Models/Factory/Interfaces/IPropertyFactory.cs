using Booking.Models.Entities;

namespace Boocking.Models.Factory.Interfaces
{
    public interface IPropertyFactory
    {
        RentableEntity CreatePropertyEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string LOCATION);
    }
}
