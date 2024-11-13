using Booking.Models.Entities;

namespace Boocking.Models.Dao.ElectronicDao
{
    public interface IElectronicDao 
    {
        void CreateElectronic();
        void UpdateElectronic(int ElectronicId, ElectronicEntity electronic);
        ElectronicEntity GetElectronicById(int ElectronicId);
        List<ElectronicEntity> GetAllElectronics();
        void DeleteElectronic(int ElectronicId);
    }
}
