using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;

namespace Boocking.Models.Dao.VehicleDao
{
    public class VehicleDaoSQLSERVER : IVehicleDao
    {
        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

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
