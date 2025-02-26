using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Booking.Models.Dao.RentableEntity
{
    public class RentableEntityDaoSQLSERVER : IRentableEntityDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public decimal GetEntityCostUsage(int rentableEntityId)
        {
            decimal entityCostUsage = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
                {
                    string query = @"
                                SELECT r.CostUsagePerDay 
                                FROM Rentables r
                                WHERE r.RentableId = @RentableId AND r.IsDeleted = 0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RentableId", rentableEntityId);

                        connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    entityCostUsage = reader.GetDecimal(0);
                                }
                            }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener el costo desde la base de datos.", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Error de conexión con la base de datos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al obtener el costo.", ex);
            }

            return entityCostUsage;
        }

    }
}
