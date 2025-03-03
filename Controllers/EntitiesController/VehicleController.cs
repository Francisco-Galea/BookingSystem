using Boocking.Models.Dao.VehicleDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Factory;
using Booking.Utility;
using Microsoft.Data.SqlClient;

namespace Boocking.Controllers.EntitiesController
{
    public class VehicleController
    {

        private readonly IVehicleFactory vehicleFactory = new VehicleFactory();
        private readonly IVehicleDao vehicleDao = new VehicleDaoSQLSERVER();

        #region Create Vehicle
        public void CreateVehicle(string vehicleType,string vehicleDescription,string costUsage,string vehicleBrand,string vehicleModel,string passengerCapacity,string serialNumber)
        {
            try
            {
                VehicleEntity vehicle = vehicleFactory.CreateVehicleEntity();
                vehicle.NAME = vehicleType;
                vehicle.DESCRIPTION = vehicleDescription;
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);
                vehicle.COSTUSAGEPERDAY = parsedCostUsage;
                vehicle.BRAND = vehicleBrand;
                vehicle.MODEL = vehicleModel;
                int parsedPassengerCapacty = ParseController.ParseToInt(passengerCapacity);
                vehicle.PASSENGERCAPACITY = parsedPassengerCapacty;
                vehicle.SERIALNUMBER = serialNumber;
                vehicleDao.InsertEntity(vehicle);
            }
            catch(ArgumentException ex) 
            {
                throw new Exception("Error al crear un vehiculo: " + ex.Message);
            }
        }
        #endregion

        #region Update Vehicle
        public void UpdateVehicle(int rentableId, string vehicleType, string vehicleDescription, string costUsage, string vehicleBrand, string vehicleModel, string passengerCapacity, string serialNumber)
        {
            try
            {
                decimal parsedCostUsage = ParseController.ParseToDecimal(costUsage);
                int parsedPassengerCapacty = ParseController.ParseToInt(passengerCapacity);

                VehicleEntity vehicle = vehicleFactory.CreateVehicleEntity();
                vehicle.NAME = vehicleType;
                vehicle.DESCRIPTION = vehicleDescription;
                vehicle.COSTUSAGEPERDAY = parsedCostUsage;
                vehicle.BRAND = vehicleBrand;
                vehicle.MODEL = vehicleModel;
                vehicle.PASSENGERCAPACITY = parsedPassengerCapacty;
                vehicle.SERIALNUMBER = serialNumber;
                vehicleDao.UpdateEntity(rentableId, vehicle);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al modificar el vehiculo: " + ex.Message);
            }
        }
        #endregion

        #region Get Vehicles Methods
        public VehicleEntity GetVehicleById(int rentableId)
        {
            return vehicleDao.GetEntityById(rentableId);
        }

        public List<VehicleEntity> GetAllVehicles()
        {
            return vehicleDao.GetAllEntities();
        }
        #endregion

        #region Delete Vehicle
        public void DeleteVehicle(int rentableId, DialogResult result)
        {
            try
            {
                if(result == DialogResult.Yes)
                {
                    vehicleDao.DeleteEntity(rentableId);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el vehiculo.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al eliminar el vehiculo.", ex);
            }
        }
        #endregion

    }
}
