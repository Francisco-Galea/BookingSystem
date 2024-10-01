using SistemaReservas.DAOs.UserDAO;
using SistemaReservas.Models;

namespace SistemaReservas.Controllers
{
    public class UserController
    {
        private readonly IUserDAO userDAO;     

        public UserController(IUserDAO userDAO)
        {
            this.userDAO = UserDaoSQLSERVER.GetInstance();
        }

        public void CreateUser(string Nombre, string Email)
        {
            User user = new(Nombre, Email);
            userDAO.InsertUser(user);
        }

        public void UpdateUser(int UserId, string Nombre, string Email)
        {
            User user = new(Nombre, Email);
            userDAO.UpdateUser(UserId, user);
        }

        public User GetUserById(int UserId)
        {
            return userDAO.GetUserById(UserId);
        }

        public List<User> GetAllUsers()
        {
            return userDAO.GetAllUsers();
        }

        public void DeleteUser(int UserId)
        {
            userDAO.DeleteUser(UserId);
        }

    }
}
