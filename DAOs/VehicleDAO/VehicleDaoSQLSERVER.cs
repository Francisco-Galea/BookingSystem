using SistemaReservas.Models;

namespace SistemaReservas.DAOs.VehicleDAO
{
    public class VehicleDaoSQLSERVER : IVehicleDAO
    {
        private static VehicleDaoSQLSERVER instanceSingleton;
        private string ConnectionString = "Server=FRANGA\\SQLEXPRESS;Database=titoRestobar;TrustServerCertificate=true; Trusted_Connection=True;";

        private VehicleDaoSQLSERVER() { }

        public static VehicleDaoSQLSERVER GetInstance()
        {
            if(instanceSingleton == null)
            {
                instanceSingleton = new VehicleDaoSQLSERVER();
            }
            return instanceSingleton;
        }

        public void CreateVehicle(Vehicle OVehicle)
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(int VehicleId)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public Vehicle GetVehicleById(int VehicleId)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(int VehicleId, Vehicle OVehicle)
        {
            throw new NotImplementedException();
        }
    }
}
