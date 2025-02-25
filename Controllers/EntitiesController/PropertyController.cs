﻿using Boocking.Models.Dao.PropertyDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Factory;
using Booking.Utility;

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
                MessageBox.Show("Propiedad creada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
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
                MessageBox.Show("Propiedad actualizada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Delete Property
        public void DeleteProperty(int rentableId)
        {
            propertyDao.DeleteEntity(rentableId);
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
