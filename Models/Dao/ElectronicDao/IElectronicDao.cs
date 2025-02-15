using Boocking.Models.Entities.RentableEntities;

namespace Boocking.Models.Dao.ElectronicDao
{
    public interface IElectronicDao 
    {
        void CreateElectronic(ElectronicEntity electronic);
        void UpdateElectronic(int ElectronicId, ElectronicEntity electronic);
        ElectronicEntity GetElectronicById(int ElectronicId);
        List<ElectronicEntity> GetAllElectronics();
        void DeleteElectronic(int ElectronicId);
    }
}
