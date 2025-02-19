using Boocking.Models.Dao.VehicleDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
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
                vehicleDao.CreateVehicle(vehicle);
                MessageBox.Show("Vehiculo creado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateVehicle(int vehicleId, string vehicleType, string vehicleDescription, string costUsage, string vehicleBrand, string vehicleModel, string passengerCapacity, string serialNumber)
        {
            try
            {
                decimal parsedCostUsage = parseController.ParseToDecimal(costUsage);
                int parsedPassengerCapacty = parseController.ParseToInt(passengerCapacity);

                VehicleEntity vehicle = vehicleFactory.CreateVehicleEntity(vehicleType, vehicleDescription, parsedCostUsage, vehicleBrand, vehicleModel, parsedPassengerCapacty, serialNumber);
                vehicleDao.UpdateVehicle(vehicleId, vehicle);
                MessageBox.Show("Vehiculo actualizado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw;
            }

        }

        public VehicleEntity GetVehicleById(int vehicleId)
        {
            return vehicleDao.GetVehicleById(vehicleId);
        }

        public List<VehicleEntity> GetAllVehicles()
        {
            return vehicleDao.GetAllVehicles();
        }
        
        public void DeleteVehicle(int vehicleId)
        {
            vehicleDao.DeleteVehicle(vehicleId);
        }

    }
}
