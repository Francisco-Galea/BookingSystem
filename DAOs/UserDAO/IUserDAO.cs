using SistemaReservas.Models;

namespace SistemaReservas.DAOs.UserDAO
{
    public interface IUserDAO
    {
        void InsertUser(User OUser);
        void UpdateUser(int UserId, User OUser);
        List<User> GetAllUsers();
        User GetUserById(int UserId);
        void DeleteUser(int UserId);
    }
}
