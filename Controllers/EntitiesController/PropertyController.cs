using Boocking.Controllers;
using Boocking.Models.Dao.PropertyDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Factory;

namespace Booking.Controllers.EntitiesController
{
    public class PropertyController
    {

        private readonly ParseController parseController = new ParseController();
        private readonly IPropertyFactory propertyFactory = new PropertyFactory();
        private readonly IPropertyDao propertyDao = new PropertyDaoSQLSERVER();

        public void CreateProperty(string propertyType, string description, string costUsage, string direction)
        {
            try
            {
                decimal parsedCostUsage = parseController.ParseToDecimal(costUsage);
                
                PropertyEntity property = propertyFactory.CreatePropertyEntity(propertyType, description, parsedCostUsage, direction);
                propertyDao.CreateProperty(property);
                MessageBox.Show("Propiedad creada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateProperty(int propertyId)
        {

        }

        public void DeleteProperty(int propertyId)
        {
            propertyDao.DeleteProperty(propertyId);
        }

        public PropertyEntity GetPropertyById(int propertyId)
        {
            return propertyDao.GetPropertyById(propertyId);
        }

        public List<PropertyEntity> GetProperties()
        {
            return propertyDao.GetAllProperties();
        }

    }
}
