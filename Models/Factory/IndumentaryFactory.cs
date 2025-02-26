using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Boocking.Models.Factory
{
    public class IndumentaryFactory : IIndumentaryFactory
    {
        public IndumentaryEntity CreateIndumentaryEntity()
        {
            return new IndumentaryEntity();
        }
    }
}
