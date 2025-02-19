using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Boocking.Models.Dao.PropertyDao
{
    public class PropertyDaoSQLSERVER : IPropertyDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void CreateProperty(PropertyEntity property)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "INSERT INTO Properties (Name, Description, CostUsagePerDay, Location) VALUES (@Name, @Description, @CostUsagePerDay, @Location)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", property.NAME);
                    command.Parameters.AddWithValue("@Description", property.DESCRIPTION);
                    command.Parameters.AddWithValue("@CostUsagePerDay", property.COSTUSAGEPERDAY);
                    command.Parameters.AddWithValue("@Location", property.LOCATION);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception("Error al crear el producto en la base de datos", ex);
                    }
                }
            }
        }

        public void DeleteProperty(int propertyId)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "UPDATE Properties SET IsDeleted = 1 WHERE PropertyId = @PropertyId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PropertyId", propertyId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al realizar el borrado lógico del producto", ex);
                    }
                }
            }
        }

        public List<PropertyEntity> GetAllProperties()
        {
            List<PropertyEntity> properties = new List<PropertyEntity>();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "SELECT PropertyId, Name, Description, CostUsagePerDay, Location FROM Properties WHERE IsDeleted = 0";

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
                    catch
                    {

                    }
                }
            }
            return properties;
        }

        public PropertyEntity GetPropertyById(int propertyId)
        {
            PropertyEntity propertyReturned = new PropertyEntity();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "SELECT PropertyId, Name, Description, CostUsagePerDay, Location FROM Properties WHERE PropertyId = @PropertyId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PropertyId", propertyId);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                propertyReturned.PROPERTYID = reader.GetInt32(0);
                                propertyReturned.NAME = reader.GetString(1);
                                propertyReturned.DESCRIPTION = reader.GetString(2);
                                propertyReturned.COSTUSAGEPERDAY= reader.GetDecimal(3); 
                                propertyReturned.LOCATION = reader.GetString(4);
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
            return propertyReturned;
        }

        public void UpdateProperty(int propertyId, PropertyEntity property)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"UPDATE Properties SET 
                                 Name = @Name,
                                 Description = @Description,
                                 CostUsagePerDay = @CostUsagePerDay,
                                 Location = @Location
                                 WHERE PropertyId = @PropertyId
                                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PropertyId", propertyId);
                    command.Parameters.AddWithValue("@Name", property.NAME);
                    command.Parameters.AddWithValue("@Description", property.DESCRIPTION);
                    command.Parameters.AddWithValue("@CostUsagePerDay", property.COSTUSAGEPERDAY);
                    command.Parameters.AddWithValue("@Location", property.LOCATION);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch
                    {

                    }
                }


            }
        }
    }
}
