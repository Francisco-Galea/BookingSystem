using Boocking.Models.Entities.RentableEntities;

namespace Boocking.Models.Dao.PropertyDao
{
    public interface IPropertyDao
    {
        void CreateProperty(PropertyEntity property);
        void UpdateProperty(int propertyId, PropertyEntity property);
        PropertyEntity GetPropertyById(int propertyId);
        List<PropertyEntity> GetAllProperties();
        void DeleteProperty(int propertyId);
    }
}
