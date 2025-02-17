
using Boocking.Models.Dao.InterfaceDao;
using Boocking.Models.Dao.VehicleDao;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Entities;
using Booking.Models.Factory;

namespace Boocking.Controllers.EntitiesController
{
    public class VehicleController
    {

        private readonly ParseController parseController = new ParseController();
        private readonly IVehicleFactory vehicleFactory = new VehicleFactory();
        private readonly IDaoSQLSERVER vehicleDao = new VehicleDaoSQLSERVER();

        public void VerifyVehicleData(string vehicleType,string vehicleDescription,string costUsage,string vehicleBrand,string vehicleModel,string passengerCapacity,string serialNumber)
        {
            try
            {
                decimal parsedCostUsage = parseController.ParseToDecimal(costUsage);
                int parsedPassengerCapacty = parseController.ParseToInt(passengerCapacity);

                RentableEntity vehiculo = vehicleFactory.CreateVehicleEntity(vehicleType, vehicleDescription, parsedCostUsage, vehicleBrand, vehicleModel, parsedPassengerCapacty, serialNumber);
                vehicleDao.CreateEntity(vehiculo);
            }
            catch
            {
                throw;
            }
        }

    }
}
