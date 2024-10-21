using SistemaReservas.Models;
using System.Data.SqlClient;

namespace SistemaReservas.DAOs.UserDAO
{
    public class UserDaoSQLSERVER : IUserDAO
    {
        private static UserDaoSQLSERVER instanceSingleton;
        private string ConnectionString = "Server=FRANGA\\SQLEXPRESS;Database=titoRestobar;TrustServerCertificate=true; Trusted_Connection=True;";
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
            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Users (UserName, Email) VALUES (@UserName, @Email)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@UserName", OUser.USERNAME);
                sqlCommand.Parameters.AddWithValue("@Email", OUser.EMAIL);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void UpdateUser(int UserId, User OUser)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int UserId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM Users WHERE UserId = @UserId";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@UserId", UserId);

                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                User user = new User();
                if (reader.Read())
                {
                    user.USERID = (int)reader["UserId"];
                    user.USERNAME = (string)reader["UserName"];
                    user.EMAIL = (string)reader["Email"];
                }
                return user;
            }
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
