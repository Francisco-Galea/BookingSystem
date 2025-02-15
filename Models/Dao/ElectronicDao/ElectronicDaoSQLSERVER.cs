using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;

namespace Boocking.Models.Dao.ElectronicDao
{
    public class ElectronicDaoSQLSERVER : IElectronicDao
    {
        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void CreateElectronic(ElectronicEntity electronic)
        {
            throw new NotImplementedException();
        }

        public void DeleteElectronic(int ElectronicId)
        {
            throw new NotImplementedException();
        }

        public List<ElectronicEntity> GetAllElectronics()
        {
            throw new NotImplementedException();
        }

        public ElectronicEntity GetElectronicById(int ElectronicId)
        {
            throw new NotImplementedException();
        }

        public void UpdateElectronic(int ElectronicId, ElectronicEntity electronic)
        {
            throw new NotImplementedException();
        }
    }
}
