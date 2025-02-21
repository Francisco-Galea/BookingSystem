using Boocking.Models.Dao.VehicleDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Controllers.Utility;
using Booking.Models.Factory;

namespace Boocking.Controllers.EntitiesController
{
    public class VehicleController
    {

        private readonly ParseController parseController = new ParseController();
        private readonly IVehicleFactory vehicleFactory = new VehicleFactory();
        private readonly IVehicleDao vehicleDao = new VehicleDaoSQLSERVER();

        public void CreateVehicle(string vehicleType,string vehicleDescription,string costUsage,string vehicleBrand,string vehicleModel,string passengerCapacity,string serialNumber)
        {
            try
            {
                decimal parsedCostUsage = parseController.ParseToDecimal(costUsage);
                int parsedPassengerCapacty = parseController.ParseToInt(passengerCapacity);

                VehicleEntity vehicle = vehicleFactory.CreateVehicleEntity(vehicleType, vehicleDescription, parsedCostUsage, vehicleBrand, vehicleModel, parsedPassengerCapacty, serialNumber);
                vehicleDao.InsertEntity(vehicle);
                MessageBox.Show("Vehiculo creado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateVehicle(int rentableId, string vehicleType, string vehicleDescription, string costUsage, string vehicleBrand, string vehicleModel, string passengerCapacity, string serialNumber)
        {
            try
            {
                decimal parsedCostUsage = parseController.ParseToDecimal(costUsage);
                int parsedPassengerCapacty = parseController.ParseToInt(passengerCapacity);

                VehicleEntity vehicle = vehicleFactory.CreateVehicleEntity(vehicleType, vehicleDescription, parsedCostUsage, vehicleBrand, vehicleModel, parsedPassengerCapacty, serialNumber);
                vehicleDao.UpdateEntity(rentableId, vehicle);
                MessageBox.Show("Vehiculo actualizado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }

        }

        public VehicleEntity GetVehicleById(int rentableId)
        {
            return vehicleDao.GetEntityById(rentableId);
        }

        public List<VehicleEntity> GetAllVehicles()
        {
            return vehicleDao.GetAllEntities();
        }
        
        public void DeleteVehicle(int rentableId)
        {
            vehicleDao.DeleteEntity(rentableId);
        }

    }
}
