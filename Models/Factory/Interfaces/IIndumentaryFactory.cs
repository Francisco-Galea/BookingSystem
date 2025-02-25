using Booking.Models.Entities;

namespace Boocking.Models.Factory.Interfaces
{
    public interface IIndumentaryFactory
    {
        RentableEntity CreateIndumentaryEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string SIZE, string GENRE);
    }
}
