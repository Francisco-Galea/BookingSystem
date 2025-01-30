using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Boocking.Models.Factory
{
    public class IndumentaryFactory : IIndumentaryFactory
    {
        public RentableEntity CreateIndumentaryEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string SIZE, string GENRE)
        {
            return new IndumentaryEntity(NAME, DESCRIPTION, COSTUSAGERPERDAY, SIZE, GENRE);
        }
    }
}
