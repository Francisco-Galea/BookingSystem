using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory;
using Boocking.Models.Factory.Interfaces;
using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Booking.Models.Dao.IndumentaryDao
{
    public class IndumentaryDaoSQLSERVER : IIndumentaryDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();
        private readonly IIndumentaryFactory indumentaryFactory = new IndumentaryFactory();

        public void DeleteEntity(int rentableId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    string deleteRentableQuery = "UPDATE Rentables SET IsDeleted = 1 WHERE RentableId = @RentableId";
                    SqlCommand deleteRentableCommand = new SqlCommand(deleteRentableQuery, connection, transaction);
                    deleteRentableCommand.Parameters.AddWithValue("@RentableId", rentableId);
                    deleteRentableCommand.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar la indumentaria en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al eliminar la indumentaria.", ex);
            }
        }

        public List<IndumentaryEntity> GetAllEntities()
        {
            List<IndumentaryEntity> indumentaries = new List<IndumentaryEntity>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string query = @"
                                SELECT r.RentableId, r.Name, r.Description, r.CostUsagePerDay, i.Size, i.Genre
                                FROM Indumentaries i
                                INNER JOIN Rentables r ON r.RentableId = i.RentableId
                                WHERE r.IsDeleted = 0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IndumentaryEntity indumentary = indumentaryFactory.CreateIndumentaryEntity();
                                indumentary.RENTABLEID = reader.GetInt32(0);
                                indumentary.NAME = reader.GetString(1);
                                indumentary.DESCRIPTION = reader.GetString(2);
                                indumentary.COSTUSAGEPERDAY = reader.GetDecimal(3);
                                indumentary.SIZE = reader.GetString(4);
                                indumentary.GENRE = reader.GetString(5);
                                indumentaries.Add(indumentary);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los vehiculos en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener los vehiculos.", ex);
            }

            return indumentaries;

        }

        public IndumentaryEntity GetEntityById(int rentableId)
        {
            IndumentaryEntity indumentaryReturned = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string query = @"
                                SELECT i.IndumentaryId, r.Name, r.Description, r.CostUsagePerDay, i.Size, i.Genre
                                FROM Indumentaries i
                                INNER JOIN Rentables r ON r.RentableId = i.RentableId
                                WHERE r.RentableId = @RentableId AND r.IsDeleted = 0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RentableId", rentableId);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                indumentaryReturned = indumentaryFactory.CreateIndumentaryEntity();
                                indumentaryReturned.INDUMENTARYID = reader.GetInt32(0);
                                indumentaryReturned.NAME = reader.GetString(1);
                                indumentaryReturned.DESCRIPTION = reader.GetString(2);
                                indumentaryReturned.COSTUSAGEPERDAY = reader.GetDecimal(3);
                                indumentaryReturned.SIZE = reader.GetString(4);
                                indumentaryReturned.GENRE = reader.GetString(5);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener la indumentaria en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener la indumentaria.", ex);
            }

            #pragma warning disable CS8603
            return indumentaryReturned;
            #pragma warning restore CS8603
        }

        public void InsertEntity(IndumentaryEntity indumentary)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        string insertRentableQuery = @"
                                                INSERT INTO Rentables (Name, Description, CostUsagePerDay) 
                                                OUTPUT INSERTED.RentableId
                                                VALUES (@Name, @Description, @CostUsagePerDay)";

                        SqlCommand rentableCommand = new SqlCommand(insertRentableQuery, connection, transaction);
                        rentableCommand.Parameters.AddWithValue("@Name", indumentary.NAME);
                        rentableCommand.Parameters.AddWithValue("@Description", indumentary.DESCRIPTION);
                        rentableCommand.Parameters.AddWithValue("@CostUsagePerDay", indumentary.COSTUSAGEPERDAY);

                        var rentableIdResult = rentableCommand.ExecuteScalar();
                        int rentableId = Convert.ToInt32(rentableIdResult);

                        string insertIndumentaryQuery = @"
                                                INSERT INTO Indumentaries (RentableId ,Size, Genre)
                                                VALUES (@RentableId, @Size, @Genre)";

                        SqlCommand vehicleCommand = new SqlCommand(insertIndumentaryQuery, connection, transaction);
                        vehicleCommand.Parameters.AddWithValue("@RentableId", rentableId);
                        vehicleCommand.Parameters.AddWithValue("@Size", indumentary.SIZE);
                        vehicleCommand.Parameters.AddWithValue("@Genre", indumentary.GENRE);
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
                throw new Exception("Error al insertar la indumentaria en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al insertar la indumentaria.", ex);
            }
        }

        public void UpdateEntity(int rentableId, IndumentaryEntity indumentary)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string updateRentableQuery = @"
                                                            UPDATE Rentables 
                                                            SET Name = @Name, 
                                                            Description = @Description, 
                                                            CostUsagePerDay = @CostUsagePerDay
                                                            WHERE RentableId = @RentableId";

                            using (SqlCommand updateRentableCommand = new SqlCommand(updateRentableQuery, connection, transaction))
                            {
                                updateRentableCommand.Parameters.AddWithValue("@RentableId", rentableId);
                                updateRentableCommand.Parameters.AddWithValue("@Name", indumentary.NAME);
                                updateRentableCommand.Parameters.AddWithValue("@Description", indumentary.DESCRIPTION);
                                updateRentableCommand.Parameters.AddWithValue("@CostUsagePerDay", indumentary.COSTUSAGEPERDAY);
                                updateRentableCommand.ExecuteNonQuery();

                            }

                            string updateIndumentaryQuery = @"
                                                        UPDATE Indumentaries 
                                                        SET Size = @Size, 
                                                        Genre = @Genre
                                                        WHERE RentableId = @RentableId";

                            using (SqlCommand updateIndumentaryCommand = new SqlCommand(updateIndumentaryQuery, connection, transaction))
                            {
                                updateIndumentaryCommand.Parameters.AddWithValue("@RentableId", rentableId);
                                updateIndumentaryCommand.Parameters.AddWithValue("@Size", indumentary.SIZE);
                                updateIndumentaryCommand.Parameters.AddWithValue("@Genre", indumentary.GENRE);
                                updateIndumentaryCommand.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al actualizar la indumentaria en la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar la indumentaria.", ex);
            }
        }
    
    }
}
