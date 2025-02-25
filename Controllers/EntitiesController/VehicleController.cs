using Boocking.Models.Dao.VehicleDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Factory;
using Booking.Utility;

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
                vehicleDao.InsertEntity(vehicle);
                MessageBox.Show("Vehiculo creado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(ArgumentException ex) 
            {
                throw new Exception("Error al agregar un vehiculo: " + ex.Message);
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
                MessageBox.Show("Vehiculo actualizado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
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
        public void DeleteVehicle(int rentableId)
        {
            vehicleDao.DeleteEntity(rentableId);
        }
        #endregion

    }
}
