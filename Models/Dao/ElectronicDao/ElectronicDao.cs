using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;
using Booking.Models.Factory;
using Booking.Models.Factory.Interface;
using Microsoft.Data.SqlClient;

namespace Booking.Models.Dao.ElectronicDao
{
    public class ElectronicDao : IElectronicDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();
        private readonly IElectronicFactory electronicFactory = new ElectronicFactory();

        public void DeleteEntity(int rentableId)
        {
            throw new NotImplementedException();
        }

        public List<ElectronicEntity> GetAllEntities()
        {
            List<ElectronicEntity> electronics = new List<ElectronicEntity>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string query = @"
                                SELECT r.RentableId, r.Name, r.Description, r.CostUsagePerDay, e.Brand, e.Model, e.SerialNumber
                                FROM Electronics e
                                INNER JOIN Rentables r ON r.RentableId = e.RentableId
                                WHERE r.IsDeleted = 0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ElectronicEntity electronic = electronicFactory.CreateElectronicEntity();
                                electronic.RENTABLEID = reader.GetInt32(0);
                                electronic.NAME = reader.GetString(1);
                                electronic.DESCRIPTION = reader.GetString(2);
                                electronic.COSTUSAGEPERDAY = reader.GetDecimal(3);
                                electronic.BRAND = reader.GetString(4);
                                electronic.MODEL = reader.GetString(5);
                                electronic.SERIALNUMBER = reader.GetString(6);
                                electronics.Add(electronic);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de consulta SQL al obtener los dispositivos electronicos en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener los dispositivos electronicos.", ex);
            }

            return electronics;
        }

        public ElectronicEntity GetEntityById(int rentableId)
        {
            throw new NotImplementedException();
        }

        public void InsertEntity(ElectronicEntity electronic)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        string rentableQuery = @"
                                                INSERT INTO Rentables (Name, Description, CostUsagePerDay) 
                                                OUTPUT INSERTED.RentableId
                                                VALUES (@Name, @Description, @CostUsagePerDay)";

                        SqlCommand rentableCommand = new SqlCommand(rentableQuery, connection, transaction);
                        rentableCommand.Parameters.AddWithValue("@Name", electronic.NAME);
                        rentableCommand.Parameters.AddWithValue("@Description", electronic.DESCRIPTION);
                        rentableCommand.Parameters.AddWithValue("@CostUsagePerDay", electronic.COSTUSAGEPERDAY);

                        var rentableIdResult = rentableCommand.ExecuteScalar();
                        int rentableId = Convert.ToInt32(rentableIdResult);

                        string vehicleQuery = @"
                                                INSERT INTO Electronics (RentableId, Brand, Model, SerialNumber)
                                                VALUES (@RentableId, @Brand, @Model, @SerialNumber)";

                        SqlCommand vehicleCommand = new SqlCommand(vehicleQuery, connection, transaction);
                        vehicleCommand.Parameters.AddWithValue("@RentableId", rentableId);
                        vehicleCommand.Parameters.AddWithValue("@Brand", electronic.BRAND);
                        vehicleCommand.Parameters.AddWithValue("@Model", electronic.MODEL);
                        vehicleCommand.Parameters.AddWithValue("@SerialNumber", electronic.SERIALNUMBER);
                        vehicleCommand.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de consulta SQL al insertar el dispositivo electronico en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al insertar el dispositivo electronico.", ex);
            }
        }

        public void UpdateEntity(int rentableId, ElectronicEntity electronic)
        {
            throw new NotImplementedException();
        }

    }
}
