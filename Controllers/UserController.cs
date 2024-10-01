using SistemaReservas.DAOs.UserDAO;
using SistemaReservas.Models;

namespace SistemaReservas.Controllers
{
    public class UserController
    {
        private readonly IUserDAO userDAO;

        public UserController(IUserDAO userDAO)
        {
            this.userDAO = userDAO;
        }

        public static void CreateUser(string Nombre, string Email)
        {
            User user = new(Nombre, Email);
            userDAO.InsertUser(user);
        }

        public static void UpdateUser(int UserId, string Nombre, string Email)
        {
            User user = new(Nombre, Email);
            userDAO.UpdateUser(UserId, user);
        }

        public static User GetUserById(int UserId)
        {
            return userDAO.GetUserById(UserId);
        }

        public static User GetAllUsers()
        {
            return userDAO.GetAllUsers();
        }

        public static void DeleteUser(int UserId)
        {
            userDAO.DeleteUser(UserId);
        }
    }
}
