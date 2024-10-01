using SistemaReservas.DAOs.VehicleDAO;
using SistemaReservas.Models;
using SistemaReservas.Models.Factory;

namespace SistemaReservas.Controllers
{
    public class VehicleController
    {
        private readonly IVehicleDAO vehicleDAO;

        public VehicleController(IVehicleDAO vehicleDAO)
        {
            this.vehicleDAO = vehicleDAO;
        }
        
        public static void CreateVehicle(string VehicleType, string Brand, string Model, decimal CostUsagePerHour)
        {
            IVehicleFactory vehicleFactory;    
            switch(VehicleType.ToLower())
            {
                case "auto":
                    vehicleFactory = CreateCarFactory();
                    Vehicle car = vehicleFactory.CreateVehicle(Brand, Model, CostUsagePerHour);
                    vehicleDAO.CreateVehicle(car);
                    break;

                case "moto":
                    vehicleFactory = CreateCarFactory();
                    Vehicle motorbike = vehicleFactory.CreateVehicle(Brand, Model, CostUsagePerHour);
                    vehicleDAO.CreateVehicle(motorbike);
                    break;

                case "camion":
                    vehicleFactory = CreateCarFactory();
                    Vehicle truck = vehicleFactory.CreateVehicle(Brand, Model, CostUsagePerHour);
                    vehicleDAO.CreateVehicle(truck);
                    break;

            }
        }

        public static IVehicleFactory CreateCarFactory()
        {
            return new CarFactory();
        }

        public static IVehicleFactory CreateTruck()
        {
            return new TruckFactory();
        }

        public static IVehicleFactory CreateMotorbike()
        {
            return new MotorbikeFactory(); 
        }

        public static void UpdateVehicle(int VehicleId, string Brand, string Model, decimal CostUsagePerHour)
        {
            
        }

        public static void DeleteVehicle(int VehicleId)
        {
            vehicleDAO.DeleteVehicle(VehicleId);
        }

        public static List<Vehicle> GetVehicles()
        {
            return vehicleDAO.GetAllVehicles();
        }

        public static Vehicle GetVehicle(int VehicleId)
        {
            return vehicleDAO.GetVehicleById(VehicleId);
        }
        
    }
}
