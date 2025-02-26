
namespace Booking.Models.Dao.RentableEntity
{
    public interface IRentableEntityDao 
    {
        decimal GetEntityCostUsage(int rentableEntityId);
    }
}
