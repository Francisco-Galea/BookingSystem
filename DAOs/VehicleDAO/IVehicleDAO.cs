using SistemaReservas.Models;

namespace SistemaReservas.DAOs.VehicleDAO
{
    public interface IVehicleDAO
    {
        void CreateVehicle(Vehicle OVehicle);
        void UpdateVehicle(int VehicleId, Vehicle OVehicle);
        Vehicle GetVehicleById(int VehicleId);
        List<Vehicle> GetAllVehicles();
        void DeleteVehicle(int VehicleId);
    }
}
