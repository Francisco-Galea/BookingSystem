using Boocking.Models.Entities.RentableEntities;
using Booking.Dtos;
using Booking.Models.Dao.ConnectionString;
using Booking.Models.Entities;
using Microsoft.Data.SqlClient;

namespace Booking.Models.Dao.BookingDao
{
    public class BookingDaoSQLSERVER : IBookingDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void InsertEntity(BookingEntity booking, int entityToRent)
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
                        bookingRentableCommand.Parameters.AddWithValue("@RentableId", entityToRent);
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

        public void DeleteEntity(int bookingId)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string deleteBookingQuery = "UPDATE Bookings SET IsDeleted = 1 WHERE BookingId = @BookingId";
                    SqlCommand deleteRentableCommand = new SqlCommand(deleteBookingQuery, connection, transaction);
                    deleteRentableCommand.Parameters.AddWithValue("@BookingId", bookingId);
                    deleteRentableCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al realizar el borrado lógico del vehículo", ex);
                }
            }
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
                                   AND b.IsDeleted = 0 
                                   AND (
                                   (@InitBooking BETWEEN b.InitBooking AND b.EndBooking) 
                                   OR (@EndBooking BETWEEN b.InitBooking AND b.EndBooking)
                                   OR (b.InitBooking BETWEEN @InitBooking AND @EndBooking) 
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

        public List<BookingVehicleDTO> GetVehiclesBooked()
        {
            List<BookingVehicleDTO> vehiclesBooked = new List<BookingVehicleDTO>();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT br.BookingId, b.InitBooking, b.EndBooking, b.DaysBooked, b.PaymentMethod, b.TotalPrice, b.IsPaid, br.RentableId, r.Name, v.Brand, v.Model, v.SerialNumber
                                FROM  BookingRentable br
                                INNER JOIN Vehicles v ON v.RentableId = br.RentableId
                                INNER JOIN Bookings b ON b.BookingId = br.BookingId
                                INNER JOIN Rentables r ON r.RentableId = br.RentableId
                                WHERE b.IsDeleted = 0
                                ORDER BY b.EndBooking DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BookingVehicleDTO vehicleBooked = new BookingVehicleDTO();
                                vehicleBooked.bookingId = reader.GetInt32(0);
                                vehicleBooked.initBooking = reader.GetDateTime(1);
                                vehicleBooked.endBooking = reader.GetDateTime(2);
                                vehicleBooked.daysBooked = reader.GetInt32(3);
                                vehicleBooked.paymentMethod = reader.GetString(4);
                                vehicleBooked.totalPrice = reader.GetDecimal(5);
                                vehicleBooked.isPaid = reader.GetBoolean(6);
                                vehicleBooked.rentableId = reader.GetInt32(7);
                                vehicleBooked.rentableName = reader.GetString(8);
                                vehicleBooked.brand = reader.GetString(9);
                                vehicleBooked.model = reader.GetString(10);
                                vehicleBooked.serialNumber = reader.GetString(11);
                                vehiclesBooked.Add(vehicleBooked);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener los vehículos", ex);
                    }
                }
            }

            return vehiclesBooked;
        }

        public List<BookingPropertyDTO> GetPropertiesBooked()
        {
            List<BookingPropertyDTO> propertiesBooked = new List<BookingPropertyDTO>();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT br.BookingId, b.InitBooking, b.EndBooking, b.DaysBooked, b.PaymentMethod, b.TotalPrice, b.IsPaid, br.RentableId, r.Name, p.Location
                                FROM  BookingRentable br
                                INNER JOIN Properties p ON p.RentableId = br.RentableId
                                INNER JOIN Bookings b ON b.BookingId = br.BookingId
                                INNER JOIN Rentables r ON r.RentableId = br.RentableId
                                WHERE b.IsDeleted = 0
                                ORDER BY b.EndBooking DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BookingPropertyDTO propertyBooked = new BookingPropertyDTO();
                                propertyBooked.bookingId = reader.GetInt32(0);
                                propertyBooked.initBooking = reader.GetDateTime(1);
                                propertyBooked.endBooking = reader.GetDateTime(2);
                                propertyBooked.daysBooked = reader.GetInt32(3);
                                propertyBooked.paymentMethod = reader.GetString(4);
                                propertyBooked.totalPrice = reader.GetDecimal(5);
                                propertyBooked.isPaid = reader.GetBoolean(6);
                                propertyBooked.rentableId = reader.GetInt32(7);
                                propertyBooked.rentableName = reader.GetString(8);
                                propertyBooked.Location = reader.GetString(9);
                                propertiesBooked.Add(propertyBooked);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener los vehículos", ex);
                    }
                }
            }

            return propertiesBooked;
        }



    }
}