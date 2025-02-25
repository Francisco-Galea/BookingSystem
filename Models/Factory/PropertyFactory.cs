using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;

namespace Booking.Models.Factory
{
    public class PropertyFactory : IPropertyFactory
    {
        public PropertyEntity CreatePropertyEntity()
        {
            return new PropertyEntity();
        }
    }
}
