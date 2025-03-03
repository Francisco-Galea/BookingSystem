using Boocking.Models.Dao.PropertyDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Factory;
using Booking.Utility;
using Microsoft.Data.SqlClient;

namespace Booking.Controllers.EntitiesController
{
    public class PropertyController
    {

        private readonly IPropertyFactory propertyFactory = new PropertyFactory();
        private readonly IPropertyDao propertyDao = new PropertyDaoSQLSERVER();

        #region Create Property
        public void CreateProperty(string propertyType, string description, string costUsage, string location)
        {
            try
            {
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);
                
                PropertyEntity property = propertyFactory.CreatePropertyEntity();
                property.NAME = propertyType;
                property.DESCRIPTION = description;
                property.COSTUSAGEPERDAY = parsedCostUsage;
                property.LOCATION = location;
                propertyDao.InsertEntity(property);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al crear una propiedad: " + ex.Message);
            }
        }
        #endregion

        #region Update Property
        public void UpdateProperty(int rentableId, string propertyType, string description, string costUsage, string location)
        {
            try
            {
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);

                PropertyEntity property = propertyFactory.CreatePropertyEntity();
                property.NAME = propertyType;
                property.DESCRIPTION = description;
                property.COSTUSAGEPERDAY = parsedCostUsage;
                property.LOCATION = location;
                propertyDao.UpdateEntity(rentableId, property);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al modificar una propiedad: " + ex.Message);
            }
        }
        #endregion

        #region Delete Property
        public void DeleteProperty(int rentableId, DialogResult result)
        {
            try
            {
                if (result == DialogResult.Yes)
                {
                    propertyDao.DeleteEntity(rentableId);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar la propiedad.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al eliminar la propiedad.", ex);
            }
        }
        #endregion

        #region Get Property Methods
        public PropertyEntity GetPropertyById(int rentableId)
        {
            return propertyDao.GetEntityById(rentableId);
        }

        public List<PropertyEntity> GetAllProperties()
        {
            return propertyDao.GetAllEntities();
        }
        #endregion

    }
}
