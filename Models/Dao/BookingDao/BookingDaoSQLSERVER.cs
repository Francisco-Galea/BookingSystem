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
    }
}