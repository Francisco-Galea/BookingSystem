using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Entities;

namespace Boocking.Models.Dao.UserDao
{
    internal interface IUserDao
    {
        void CreateUser(UserEntity user);
        void UpdateUser(int UserId, UserEntity user);
        UserEntity GetUserById(int UserId);
        List<UserEntity> GetAllUsers();
        void DeleteUser(int UserId);
    }
}
