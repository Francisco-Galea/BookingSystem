using Booking.Models.Dao.ConnectionString;
using Booking.Models.Entities;

namespace Boocking.Models.Dao.UserDao
{
    public class UserDaoSQLSERVER : IUserDao
    {
        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void CreateUser(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUserById(int UserId)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int UserId, UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
