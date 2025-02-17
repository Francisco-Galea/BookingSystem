using Boocking.Models.Dao.InterfaceDao;
using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;
using Booking.Models.Entities;

namespace Boocking.Models.Dao.VehicleDao
{
    public class VehicleDaoSQLSERVER : IDaoSQLSERVER
    {
        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void CreateEntity(RentableEntity rentableEntity)
        {
            throw new NotImplementedException();
        }

        public void CreateVehicle()
        {
            throw new NotImplementedException();
        }

        public void DeleteVehicle(int VehicleId)
        {
            throw new NotImplementedException();
        }

        public List<VehicleEntity> GetAllVehicle()
        {
            throw new NotImplementedException();
        }

        public VehicleEntity GetVehicleById(int VehicleId)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(int VehicleId, VehicleEntity vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
