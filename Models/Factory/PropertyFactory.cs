using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class PropertyFactory : IPropertyFactory
    {
        public RentableEntity CreatePropertyEntity(string LOCATION, string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY)
        {
            return new PropertyEntity(LOCATION, NAME, DESCRIPTION, COSTUSAGERPERDAY);
        }
    }
}
