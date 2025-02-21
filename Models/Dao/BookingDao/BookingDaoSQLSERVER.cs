using Booking.Models.Dao.ConnectionString;
using Booking.Models.Entities;
using Microsoft.Data.SqlClient;

namespace Booking.Models.Dao.BookingDao
{
    public class BookingDaoSQLSERVER : IBookingDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void InsertEntity(BookingEntity booking)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string rentableQuery = @"
                    INSERT INTO Bookings (RentableId, InitBooking, EndBooking, DaysBooked, PaymentMethod, TotalPrice, IsPaid, CreatedAt) 
                    VALUES (@RentableId, @InitBooking, @EndBooking, @DaysBooked, @PaymentMethod, @TotalPrice, @IsPaid, @CreatedAt)";

                    SqlCommand bookingCommand = new SqlCommand(rentableQuery, connection, transaction);
                    bookingCommand.Parameters.AddWithValue("@RentableId", booking.RENTABLEID);
                    bookingCommand.Parameters.AddWithValue("@InitBooking", booking.INITBOOKING);
                    bookingCommand.Parameters.AddWithValue("@EndBooking", booking.ENDBOOKING);
                    bookingCommand.Parameters.AddWithValue("@DaysBooked", booking.DAYSBOOKED);
                    bookingCommand.Parameters.AddWithValue("@PaymentMethod", booking.OSELECTEDSTRATEGY.ToString());
                    bookingCommand.Parameters.AddWithValue("@TotalPrice", booking.FINALPRICE);
                    bookingCommand.Parameters.AddWithValue("@IsPaid", booking.ISPAID);
                    bookingCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    
                    bookingCommand.ExecuteNonQuery();

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al crear el vehiculo", ex);
                }
            }
        }

        public void DeleteEntity(int BookingId)
        {
            throw new NotImplementedException();
        }

        public List<BookingEntity> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public BookingEntity GetEntityById(int BookingId)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(int BookingId, BookingEntity booking)
        {
            throw new NotImplementedException();
        }

        public bool CheckAvailabilityForEntity(int entityToRentId, DateOnly initBooking, DateOnly endBooking)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                connection.Open();

                try
                {
                    string query = @"
                    SELECT COUNT(*) 
                    FROM Bookings 
                    WHERE RentableId = @RentableId
                    AND (
                        (@InitBooking BETWEEN InitBooking AND EndBooking) -- El inicio de la nueva reserva se encuentra entre el rango de la reserva existente
                        OR (@EndBooking BETWEEN InitBooking AND EndBooking) -- El fin de la nueva reserva se encuentra entre el rango de la reserva existente
                        OR (InitBooking BETWEEN @InitBooking AND @EndBooking) -- El rango de la reserva existente se encuentra dentro de la nueva reserva
                    )";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RentableId", entityToRentId);
                    command.Parameters.AddWithValue("@InitBooking", initBooking.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@EndBooking", endBooking.ToString("yyyy-MM-dd"));

                    int count = (int)command.ExecuteScalar();

                    return count == 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al comprobar la disponibilidad en la base de datos", ex);
                }
            }
        }


    }
}