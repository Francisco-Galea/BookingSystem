using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;

namespace Boocking.Models.Dao.PropertyDao
{
    public class PropertyDaoSQLSERVER : IPropertyDao
    {
        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void CreateProperty(PropertyEntity property)
        {
            throw new NotImplementedException();
        }

        public void DeleteProperty(int PropertyId)
        {
            throw new NotImplementedException();
        }

        public List<PropertyEntity> GetAllProperties()
        {
            throw new NotImplementedException();
        }

        public PropertyEntity GetPropertyById(int PropertyId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProperty(int PropertyId, PropertyEntity property)
        {
            throw new NotImplementedException();
        }
    }
}
