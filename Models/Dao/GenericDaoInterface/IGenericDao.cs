
namespace Booking.Models.Dao.GenericDaoInterface
{
    public interface IGenericDao <T> where T : class
    {
        void InsertEntity(T entity);
        void UpdateEntity(int rentableEntityId,T entity);
        T GetEntityById(int rentableEntityId);
        List<T> GetAllEntities();
        void DeleteEntity(int rentableEntityId);

    }
}
