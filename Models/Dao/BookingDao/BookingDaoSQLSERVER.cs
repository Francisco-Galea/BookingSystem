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
                    string bookingQuery = @"
                                          INSERT INTO Bookings (InitBooking, EndBooking, DaysBooked, PaymentMethod, TotalPrice, IsPaid, IsActiveToUpdate, CreatedAt, IsDeleted) 
                                          VALUES (@InitBooking, @EndBooking, @DaysBooked, @PaymentMethod, @TotalPrice, @IsPaid, @IsActiveToUpdate, @CreatedAt, @IsDeleted);
                                          SELECT SCOPE_IDENTITY();";  // Obtiene el ID recién insertado

                    SqlCommand bookingCommand = new SqlCommand(bookingQuery, connection, transaction);
                    bookingCommand.Parameters.AddWithValue("@InitBooking", booking.INITBOOKING);
                    bookingCommand.Parameters.AddWithValue("@EndBooking", booking.ENDBOOKING);
                    bookingCommand.Parameters.AddWithValue("@DaysBooked", booking.DAYSBOOKED);
                    bookingCommand.Parameters.AddWithValue("@PaymentMethod", booking.OSELECTEDSTRATEGY.ToString());
                    bookingCommand.Parameters.AddWithValue("@TotalPrice", booking.FINALPRICE);
                    bookingCommand.Parameters.AddWithValue("@IsPaid", booking.ISPAID);
                    bookingCommand.Parameters.AddWithValue("@IsActiveToUpdate", true);
                    bookingCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    bookingCommand.Parameters.AddWithValue("@IsDeleted", false);

                    int bookingId = Convert.ToInt32(bookingCommand.ExecuteScalar()); // Obtiene el ID

                   
                        string bookingRentableQuery = @"
                INSERT INTO BookingRentable (BookingId, RentableId) 
                VALUES (@BookingId, @RentableId)";

                        SqlCommand bookingRentableCommand = new SqlCommand(bookingRentableQuery, connection, transaction);
                        bookingRentableCommand.Parameters.AddWithValue("@BookingId", bookingId);
                        bookingRentableCommand.Parameters.AddWithValue("@RentableId", booking.RENTABLEID);
                        bookingRentableCommand.ExecuteNonQuery();
                    

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al crear la reserva y su relación con rentables", ex);
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
            FROM BookingRentable br
            INNER JOIN Bookings b ON br.BookingId = b.BookingId
            WHERE br.RentableId = @RentableId
            AND b.IsDeleted = 0 -- Aseguramos que la reserva sigue activa
            AND (
                (@InitBooking BETWEEN b.InitBooking AND b.EndBooking) -- Nueva reserva comienza dentro de una reserva existente
                OR (@EndBooking BETWEEN b.InitBooking AND b.EndBooking) -- Nueva reserva termina dentro de una reserva existente
                OR (b.InitBooking BETWEEN @InitBooking AND @EndBooking) -- Reserva existente está contenida en la nueva reserva
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