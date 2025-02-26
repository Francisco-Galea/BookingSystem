using Boocking.Models.Entities;
using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Booking.Models.Dao.ClientDao
{
    public class ClientDaoSQLSERVER : IClientDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

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
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar el cliente en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al insertar el cliente.", ex);
            }
        }

        #pragma warning disable CS8766 
        public ClientEntity? GetEntityById(int clientId)
        #pragma warning restore CS8766 
        {
            ClientEntity? client = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string query = @"
                        SELECT ClientId, Name, LastName, PhoneNumber 
                        FROM Clients WHERE IsDeleted = 0 AND ClientId = @ClientId";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientId", clientId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                client = new ClientEntity
                                {
                                    CLIENTID = reader.GetInt32(0),
                                    NAME = reader.GetString(1),
                                    LASTNAME = reader.GetString(2),
                                    PHONENUMBER = reader.GetString(3)
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener el cliente desde la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener el cliente.", ex);
            }

            return client;
        }

        public List<ClientEntity> GetAllEntities()
        {
            List<ClientEntity> clients = new List<ClientEntity>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string query = "SELECT ClientId, Name, LastName, PhoneNumber FROM Clients WHERE IsDeleted = 0";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClientEntity client = new ClientEntity
                            {
                                CLIENTID = reader.GetInt32(0),
                                NAME = reader.GetString(1),
                                LASTNAME = reader.GetString(2),
                                PHONENUMBER = reader.GetString(3)
                            };
                            clients.Add(client);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los clientes.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener los clientes.", ex);
            }

            return clients;
        }

        public void UpdateEntity(int clientId, ClientEntity entity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string updateQuery = @"
                        UPDATE Clients 
                        SET Name = @Name, LastName = @LastName, PhoneNumber = @PhoneNumber
                        WHERE ClientId = @ClientId AND IsDeleted = 0;";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", entity.NAME);
                        command.Parameters.AddWithValue("@LastName", entity.LASTNAME);
                        command.Parameters.AddWithValue("@PhoneNumber", entity.PHONENUMBER);
                        command.Parameters.AddWithValue("@ClientId", clientId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró un cliente activo con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar el cliente en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el cliente.", ex);
            }
        }

        public void DeleteEntity(int clientId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string deleteQuery = @"
                        UPDATE Clients 
                        SET IsDeleted = 1
                        WHERE ClientId = @ClientId AND IsDeleted = 0;";

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ClientId", clientId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró un cliente activo con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el cliente en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al eliminar el cliente.", ex);
            }
        }


    }
}
