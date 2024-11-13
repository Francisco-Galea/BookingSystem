using Booking.Models.Entities;

namespace Boocking.Models.Dao.VehicleDao
{
    public interface IVehicleDao
    {
        void CreateVehicle();
        void UpdateVehicle(int VehicleId, VehicleEntity vehicle);
        VehicleEntity GetVehicleById(int VehicleId);
        List<VehicleEntity> GetAllVehicle();
        void DeleteVehicle(int VehicleId);
    }
}
