using Booking.Models.Dao.GenericDaoInterface;

namespace Booking.Models.Dao.RentableEntity
{
    public interface IRentableEntityDao 
    {
        decimal GetEntityCostUsage(int rentableEntityId);
    }
}
