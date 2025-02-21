using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Boocking.Models.Dao.PropertyDao
{
    public class PropertyDaoSQLSERVER : IPropertyDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void InsertEntity(PropertyEntity property)
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
                    rentableCommand.Parameters.AddWithValue("@Name", property.NAME);
                    rentableCommand.Parameters.AddWithValue("@Description", property.DESCRIPTION);
                    rentableCommand.Parameters.AddWithValue("@CostUsagePerDay", property.COSTUSAGEPERDAY);

                    int rentableId = Convert.ToInt32(rentableCommand.ExecuteScalar());

                    string propertyQuery = @"
                                            INSERT INTO Properties (RentableId, Location) 
                                            VALUES (@RentableId, @Location)";

                    SqlCommand propertyCommand = new SqlCommand(propertyQuery, connection, transaction);
                    propertyCommand.Parameters.AddWithValue("@RentableId", rentableId);
                    propertyCommand.Parameters.AddWithValue("@Location", property.LOCATION);

                    propertyCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al crear la propiedad", ex);
                }
            }
        }

        public void DeleteEntity(int rentableId)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteRentableQuery = "UPDATE Rentables SET IsDeleted = 1 WHERE RentableId = @RentableId";
                    SqlCommand deleteRentableCommand = new SqlCommand(deleteRentableQuery, connection, transaction);
                    deleteRentableCommand.Parameters.AddWithValue("@RentableId", rentableId);
                    deleteRentableCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al realizar el borrado lógico de la propiedad", ex);
                }
            }
        }

        public List<PropertyEntity> GetAllEntities()
        {
            List<PropertyEntity> properties = new List<PropertyEntity>();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT r.RentableId, r.Name, r.Description, r.CostUsagePerDay, p.Location 
                                FROM Properties p
                                INNER JOIN Rentables r ON p.RentableId = r.RentableId
                                WHERE r.IsDeleted = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PropertyEntity property = new PropertyEntity();
                                property.PROPERTYID = reader.GetInt32(0);
                                property.NAME = reader.GetString(1);
                                property.DESCRIPTION = reader.GetString(2);
                                property.COSTUSAGEPERDAY = reader.GetDecimal(3);
                                property.LOCATION = reader.GetString(4);
                                properties.Add(property);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener las propiedades", ex);
                    }
                }
            }

            return properties;
        }

        public PropertyEntity GetEntityById(int rentableId)
        {
            PropertyEntity propertyReturned = null;

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT p.PropertyId, r.Name, r.Description, r.CostUsagePerDay, p.Location 
                                FROM Properties p
                                INNER JOIN Rentables r ON p.RentableId = r.RentableId
                                WHERE p.PRentableId = @RentableId AND r.IsDeleted = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentableId", rentableId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                propertyReturned = new PropertyEntity();
                                propertyReturned.PROPERTYID = reader.GetInt32(0);
                                propertyReturned.NAME = reader.GetString(1);
                                propertyReturned.DESCRIPTION = reader.GetString(2);
                                propertyReturned.COSTUSAGEPERDAY = reader.GetDecimal(3);
                                propertyReturned.LOCATION = reader.GetString(4);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener la propiedad", ex);
                    }
                }
            }

            return propertyReturned;
        }

        public void UpdateEntity(int rentableId, PropertyEntity property)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updatePropertyQuery = @"
                                                    UPDATE Properties SET Location = @Location 
                                                    WHERE WHERE RentableId = @RentableId";

                    SqlCommand updatePropertyCommand = new SqlCommand(updatePropertyQuery, connection, transaction);
                    updatePropertyCommand.Parameters.AddWithValue("@RentableId", rentableId);
                    updatePropertyCommand.Parameters.AddWithValue("@Location", property.LOCATION);
                    updatePropertyCommand.ExecuteNonQuery();

                    string updateRentableQuery = @"
                                                    UPDATE Rentables SET Name = @Name, Description = @Description, CostUsagePerDay = @CostUsagePerDay 
                                                    WHERE RentableId = @RentableId";

                    SqlCommand updateRentableCommand = new SqlCommand(updateRentableQuery, connection, transaction);
                    updateRentableCommand.Parameters.AddWithValue("@RentableId", rentableId);
                    updateRentableCommand.Parameters.AddWithValue("@Name", property.NAME);
                    updateRentableCommand.Parameters.AddWithValue("@Description", property.DESCRIPTION);
                    updateRentableCommand.Parameters.AddWithValue("@CostUsagePerDay", property.COSTUSAGEPERDAY);
                    updateRentableCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al actualizar la propiedad", ex);
                }
            }
        }

    }
}