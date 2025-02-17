using Booking.Models.Entities;

namespace Boocking.Models.Dao.InterfaceDao
{
    public interface IDaoSQLSERVER
    {
        void CreateEntity(RentableEntity rentableEntity);
    }
}
