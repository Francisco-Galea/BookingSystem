using SistemaReservas.Models;

namespace SistemaReservas.DAOs.UserDAO
{
    public class UserDaoSQLSERVER : IUserDAO
    {
        private static UserDaoSQLSERVER instanceSingleton;        
        private UserDaoSQLSERVER() { }

        public static UserDaoSQLSERVER GetInstance()
        {
            if (instanceSingleton == null)
            {
                instanceSingleton = new UserDaoSQLSERVER();
            }
            return instanceSingleton;
        }    

        public void InsertUser(User OUser)
        {
            
        }

        public void UpdateUser(int UserId, User OUser)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int UserId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int UserId)
        {
            throw new NotImplementedException();
        }
    }
}
