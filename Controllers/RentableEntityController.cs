

using Booking.Models.Dao.RentableEntity;

namespace Booking.Controllers
{
    public class RentableEntityController
    {

        private readonly IRentableEntityDao rentableEntityDao = new RentableEntityDaoSQLSERVER();

        public decimal GetEntityCostUsage(int rentableEntityId)
        {
            return rentableEntityDao.GetEntityCostUsage(rentableEntityId);
        }

    }
}
