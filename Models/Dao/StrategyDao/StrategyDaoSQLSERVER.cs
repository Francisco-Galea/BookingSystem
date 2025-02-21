
using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Booking.Models.Dao.StrategyDao
{
    public class StrategyDaoSQLSERVER : IStrategyDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();


        public int GetPaymentStrategyId(string paymentMethod)
        {
            int strategyId = 0;

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                connection.Open();
                string query = @"SELECT PaymentStrategyId
                             FROM PaymentStrategies 
                             WHERE PaymentMethod = @PaymentMethod";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            strategyId = reader.GetInt32(0);
                        }
                    }
                }
            }
            return strategyId;
        }

    }
}
