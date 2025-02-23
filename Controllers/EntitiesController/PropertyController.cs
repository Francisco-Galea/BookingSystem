using Boocking.Models.Dao.PropertyDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Controllers.Utility;
using Booking.Models.Factory;

namespace Booking.Controllers.EntitiesController
{
    public class PropertyController
    {

        private readonly IPropertyFactory propertyFactory = new PropertyFactory();
        private readonly IPropertyDao propertyDao = new PropertyDaoSQLSERVER();

        public void CreateProperty(string propertyType, string description, string costUsage, string location)
        {
            try
            {
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);
                
                PropertyEntity property = propertyFactory.CreatePropertyEntity(propertyType, description, parsedCostUsage, location);
                propertyDao.InsertEntity(property);
                MessageBox.Show("Propiedad creada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateProperty(int rentableId, string propertyType, string description, string costUsage, string location)
        {
            try
            {
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);

                PropertyEntity property = propertyFactory.CreatePropertyEntity(propertyType, description, parsedCostUsage, location);
                propertyDao.UpdateEntity(rentableId, property);
                MessageBox.Show("Propiedad actualizada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteProperty(int rentableId)
        {
            propertyDao.DeleteEntity(rentableId);
        }

        public PropertyEntity GetPropertyById(int rentableId)
        {
            return propertyDao.GetEntityById(rentableId);
        }

        public List<PropertyEntity> GetAllProperties()
        {
            return propertyDao.GetAllEntities();
        }

    }
}
