using Booking.Models.Entities;

namespace Booking.Models.Factory.Interface
{
    public interface IElectronicFactory
    {
        RentableEntity CreateElectronicEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string BRAND, string MODEL, string SERIALNUMBER);
    }
}
