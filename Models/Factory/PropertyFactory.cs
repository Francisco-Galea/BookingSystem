using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;

namespace Booking.Models.Factory
{
    public class PropertyFactory : IPropertyFactory
    {
        public PropertyEntity CreatePropertyEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string LOCATION)
        {
            return new PropertyEntity(NAME, DESCRIPTION, COSTUSAGERPERDAY, LOCATION);
        }
    }
}
