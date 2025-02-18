using Boocking.Models.Entities.RentableEntities;

namespace Boocking.Models.Dao.VehicleDao
{
    public interface IVehicleDao
    {
        void CreateVehicle(VehicleEntity vehicle);
        void UpdateVehicle(int VehicleId, VehicleEntity vehicle);
        VehicleEntity GetVehicleById(int VehicleId);
        List<VehicleEntity> GetAllVehicle();
        void DeleteVehicle(int VehicleId);
    }
}
