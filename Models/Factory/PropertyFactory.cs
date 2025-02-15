using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;

namespace Booking.Models.Factory
{
    public class PropertyFactory : IPropertyFactory
    {
        public RentableEntity CreatePropertyEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string LOCATION)
        {
            return new PropertyEntity(NAME, DESCRIPTION, COSTUSAGERPERDAY, LOCATION);
        }
    }
}
