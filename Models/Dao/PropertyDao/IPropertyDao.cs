using Booking.Models.Entities;

namespace Boocking.Models.Dao.PropertyDao
{
    public interface IPropertyDao
    {
        void CreateProperty();
        void UpdateProperty(int PropertyId, PropertyEntity property);
        PropertyEntity GetPropertyById(int PropertyId);
        List<PropertyEntity> GetAllProperties();
        void DeleteProperty(int PropertyId);
    }
}
