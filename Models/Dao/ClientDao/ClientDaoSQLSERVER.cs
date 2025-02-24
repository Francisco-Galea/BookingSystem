using Boocking.Models.Entities;
using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Booking.Models.Dao.ClientDao
{
    public class ClientDaoSQLSERVER : IClientDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void DeleteEntity(int rentableEntityId)
        {
            throw new NotImplementedException();
        }

        public List<ClientEntity> GetAllEntities()
        {
            List<ClientEntity> clients = new List<ClientEntity>();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "SELECT ClientId, Name, LastName, PhoneNumber FROM Clients WHERE IsDeleted = 0";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClientEntity client = new ClientEntity
                            (
                                reader.GetString(1), 
                                reader.GetString(2), 
                                reader.GetString(3) 
                            );
                            client.CLIENTID = reader.GetInt32(0); 
                            clients.Add(client);
                        }
                    }
                }
            }
            return clients;
        }

        public ClientEntity GetEntityById(int clientId)
        {
            ClientEntity client = null;

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT ClientId, Name, LastName, PhoneNumber FROM Clients WHERE IsDeleted = 0 AND ClientId = @clientId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", clientId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                client = new ClientEntity();
                                client.CLIENTID = reader.GetInt32(0);
                                client.NAME = reader.GetString(1);
                                client.LASTNAME = reader.GetString(2);
                                client.PHONENUMBER = reader.GetString(3);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            return client;
        }

        public void InsertEntity(ClientEntity clientEntity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string insertQuery = @"
                                    INSERT INTO Clients (Name, LastName, PhoneNumber, CreatedAt) 
                                    VALUES (@Name, @LastName, @PhoneNumber, @CreatedAt);";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", clientEntity.NAME);
                        command.Parameters.AddWithValue("@LastName", clientEntity.LASTNAME);
                        command.Parameters.AddWithValue("@PhoneNumber", clientEntity.PHONENUMBER);
                        command.Parameters.AddWithValue("@CreatedAt", clientEntity.CREATEDAT);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch 
            {
            }
        }

        public void UpdateEntity(int rentableEntityId, ClientEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}
