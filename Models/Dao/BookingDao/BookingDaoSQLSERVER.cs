using Boocking.Models.Entities;
using Booking.Dtos.BookedEntities;
using Booking.Dtos.CoreDataBooking;
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
                                          INSERT INTO Bookings (InitBooking, EndBooking, ClientId ,DaysBooked, PaymentMethod, TotalPrice, IsPaid, IsActiveToUpdate, CreatedAt, IsDeleted) 
                                          VALUES (@InitBooking, @EndBooking, @ClientId, @DaysBooked, @PaymentMethod, @TotalPrice, @IsPaid, @IsActiveToUpdate, @CreatedAt, @IsDeleted);
                                          SELECT SCOPE_IDENTITY();";  

                    SqlCommand bookingCommand = new SqlCommand(bookingQuery, connection, transaction);
                    bookingCommand.Parameters.AddWithValue("@InitBooking", booking.INITBOOKING);
                    bookingCommand.Parameters.AddWithValue("@EndBooking", booking.ENDBOOKING);
                    bookingCommand.Parameters.AddWithValue("@ClientId", booking.OCLIENT.CLIENTID);
                    bookingCommand.Parameters.AddWithValue("@DaysBooked", booking.DAYSBOOKED);
                    bookingCommand.Parameters.AddWithValue("@PaymentMethod", booking.OSELECTEDSTRATEGY.ToString());
                    bookingCommand.Parameters.AddWithValue("@TotalPrice", booking.FINALPRICE);
                    bookingCommand.Parameters.AddWithValue("@IsPaid", booking.ISPAID);
                    bookingCommand.Parameters.AddWithValue("@IsActiveToUpdate", true);
                    bookingCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    bookingCommand.Parameters.AddWithValue("@IsDeleted", false);

                    int bookingId = Convert.ToInt32(bookingCommand.ExecuteScalar());

                   
                        string bookingRentableQuery = @"
                                                      INSERT INTO BookingRentable (BookingId, RentableId) 
                                                      VALUES (@BookingId, @RentableId)";

                        SqlCommand bookingRentableCommand = new SqlCommand(bookingRentableQuery, connection, transaction);
                        bookingRentableCommand.Parameters.AddWithValue("@BookingId", bookingId);
                        bookingRentableCommand.Parameters.AddWithValue("@RentableId", entityToRent);
                        bookingRentableCommand.ExecuteNonQuery();
                    

                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error en la consulta SQL al crear la reserva.", ex);
                }
                catch (InvalidOperationException ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error de conexión con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al crear la reserva", ex);
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
                catch (SqlException ex)
                {
                    throw new Exception("Error en la consulta SQL al eliminar la reserva.", ex);
                }
                catch (InvalidOperationException ex)
                {
                    throw new Exception("Error de conexión con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la reserva", ex);
                }
            }
        }


        public BookingCoreDataDto GetBookingCoreData(int bookingId)
        {
            BookingCoreDataDto bookingData = new BookingCoreDataDto();
            ClientEntity client = new ClientEntity();

            string query = @"
                    SELECT b.InitBooking, b.EndBooking, b.PaymentMethod, b.IsPaid, c.Name, c.LastName, c.PhoneNumber 
                    FROM  Bookings b
                    INNER JOIN Clients c ON c.ClientId = b.ClientId
                    WHERE b.IsDeleted = 0 AND b.BookingId = @BookingId";

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BookingId", bookingId);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bookingData.initBooking = reader.GetDateTime(0);
                            bookingData.endBooking = reader.GetDateTime(1);
                            bookingData.paymentMethod = reader.GetString(2);
                            bookingData.isPaid = reader.GetBoolean(3);
                            client.NAME = reader.GetString(4);
                            client.LASTNAME = reader.GetString(5);
                            client.PHONENUMBER = reader.GetString(6);
                            bookingData.oClient = client;
                        }
                        else
                        {
                            throw new Exception("No se encontraron datos para la reserva.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error en la consulta SQL para obtener los datos de la reserva.", ex);
                }
                catch (InvalidOperationException ex)
                {
                    throw new Exception("Error de conexion con la base de datos", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al traer los datos reserva.", ex);
                }
            }

            return bookingData;
        }

        public void UpdateEntity(int bookingId, BookingEntity bookingEntity, int entityToRentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();  

                try
                {
                    string updateBookingQuery = @"
                                                UPDATE Bookings SET 
                                                InitBooking = @initBooking,
                                                EndBooking = @endBooking,
                                                ClientId = @clientId,
                                                DaysBooked = @daysBooked,
                                                TotalPrice = @totalPrice,
                                                IsPaid = @isPaid
                                                WHERE BookingId = @bookingId
                                                ";

                    SqlCommand updateBookingCommand = new SqlCommand(updateBookingQuery, connection, transaction);
                    updateBookingCommand.Parameters.AddWithValue("@bookingId", bookingId);
                    updateBookingCommand.Parameters.AddWithValue("@initBooking", bookingEntity.INITBOOKING);
                    updateBookingCommand.Parameters.AddWithValue("@endBooking", bookingEntity.ENDBOOKING);
                    updateBookingCommand.Parameters.AddWithValue("@clientId", bookingEntity.OCLIENT.CLIENTID);
                    updateBookingCommand.Parameters.AddWithValue("@daysBooked", bookingEntity.DAYSBOOKED);
                    updateBookingCommand.Parameters.AddWithValue("@totalPrice", bookingEntity.FINALPRICE);
                    updateBookingCommand.Parameters.AddWithValue("@isPaid", bookingEntity.ISPAID);
                    updateBookingCommand.ExecuteNonQuery();

                    string updateRentableQuery = @"
                                                    UPDATE BookingRentable SET 
                                                    RentableId = @entityToRentId
                                                    WHERE BookingId = @bookingId
                                                    ";

                    SqlCommand updateRentableCommand = new SqlCommand(updateRentableQuery, connection, transaction);
                    updateRentableCommand.Parameters.AddWithValue("@bookingId", bookingId);
                    updateRentableCommand.Parameters.AddWithValue("@entityToRentId", entityToRentId);
                    updateRentableCommand.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();  
                    throw new Exception("Error en la consulta SQL al actualizar la reserva.", ex);
                }
                catch (InvalidOperationException ex)
                {
                    transaction.Rollback(); 
                    throw new Exception("Error de conexión con la base de datos.", ex);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();  
                    throw new Exception("Error al actualizar la reserva.", ex);
                }
            }
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

        public bool CheckAvailabilityForExistingBooking(int entityToRentId, int currentBookingId, DateOnly initBooking, DateOnly endBooking)
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
                                    AND b.BookingId <> @CurrentBookingId  --- Se excluye la reserva actual
                                    AND (
                                        (@InitBooking BETWEEN b.InitBooking AND b.EndBooking) 
                                        OR (@EndBooking BETWEEN b.InitBooking AND b.EndBooking)
                                        OR (b.InitBooking BETWEEN @InitBooking AND @EndBooking)
                                        )";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RentableId", entityToRentId);
                    command.Parameters.AddWithValue("@CurrentBookingId", currentBookingId);
                    command.Parameters.AddWithValue("@InitBooking", initBooking.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@EndBooking", endBooking.ToString("yyyy-MM-dd"));

                    int count = (int)command.ExecuteScalar();
                    return count == 0; 
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al comprobar la disponibilidad", ex);
                }
            }
        }

        public List<BookingVehicleDTO> GetVehiclesBooked()
        {
            List<BookingVehicleDTO> vehiclesBooked = new List<BookingVehicleDTO>();
            ClientEntity client = new ClientEntity();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT br.BookingId, b.InitBooking, b.EndBooking, b.DaysBooked, b.PaymentMethod, b.TotalPrice, b.IsPaid, br.RentableId, r.Name, v.Brand, v.Model, v.SerialNumber, c.Name, c.LastName, c.PhoneNumber
                                FROM  BookingRentable br
                                INNER JOIN Vehicles v ON v.RentableId = br.RentableId
                                INNER JOIN Bookings b ON b.BookingId = br.BookingId
                                INNER JOIN Rentables r ON r.RentableId = br.RentableId
                                INNER JOIN Clients c ON c.ClientId = b.ClientId
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
                                client.NAME = reader.GetString(12);
                                client.LASTNAME = reader.GetString(13);
                                client.PHONENUMBER = reader.GetString(14);
                                vehicleBooked.oClient = client;
                                vehiclesBooked.Add(vehicleBooked);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener los vehículos reservados", ex);
                    }
                }
            }

            return vehiclesBooked;
        }

        public List<BookingPropertyDTO> GetPropertiesBooked()
        {
            List<BookingPropertyDTO> propertiesBooked = new List<BookingPropertyDTO>();
            ClientEntity client = new ClientEntity();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT br.BookingId, b.InitBooking, b.EndBooking, b.DaysBooked, b.PaymentMethod, b.TotalPrice, b.IsPaid, br.RentableId, r.Name, p.Location, c.Name, c.LastName, c.PhoneNumber, r.Description
                                FROM  BookingRentable br
                                INNER JOIN Properties p ON p.RentableId = br.RentableId
                                INNER JOIN Bookings b ON b.BookingId = br.BookingId
                                INNER JOIN Rentables r ON r.RentableId = br.RentableId
                                INNER JOIN Clients c ON c.ClientId = b.ClientId
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
                                client.NAME = reader.GetString(10);
                                client.LASTNAME = reader.GetString(11);
                                client.PHONENUMBER = reader.GetString(12);
                                propertyBooked.description = reader.GetString(13);
                                propertyBooked.oClient = client;
                                propertiesBooked.Add(propertyBooked);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener las propiedades reservadas", ex);
                    }
                }
            }

            return propertiesBooked;
        }

        public List<BookingIndumentaryDto> GetIndumentariesBooked()
        {
            List<BookingIndumentaryDto> indumentariesBooked = new List<BookingIndumentaryDto>();
            ClientEntity client = new ClientEntity();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT br.BookingId, b.InitBooking, b.EndBooking, b.DaysBooked, b.PaymentMethod, b.TotalPrice, b.IsPaid, br.RentableId, r.Name, i.Size, i.Genre, r.Description, c.Name, c.LastName, c.PhoneNumber
                                FROM  BookingRentable br
                                INNER JOIN Indumentaries i ON i.RentableId = br.RentableId
                                INNER JOIN Bookings b ON b.BookingId = br.BookingId
                                INNER JOIN Rentables r ON r.RentableId = br.RentableId
                                INNER JOIN Clients c ON c.ClientId = b.ClientId
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
                                BookingIndumentaryDto indumentaryBooked = new BookingIndumentaryDto();
                                indumentaryBooked.bookingId = reader.GetInt32(0);
                                indumentaryBooked.initBooking = reader.GetDateTime(1);
                                indumentaryBooked.endBooking = reader.GetDateTime(2);
                                indumentaryBooked.daysBooked = reader.GetInt32(3);
                                indumentaryBooked.paymentMethod = reader.GetString(4);
                                indumentaryBooked.totalPrice = reader.GetDecimal(5);
                                indumentaryBooked.isPaid = reader.GetBoolean(6);
                                indumentaryBooked.rentableId = reader.GetInt32(7);
                                indumentaryBooked.rentableName = reader.GetString(8);
                                indumentaryBooked.size = reader.GetString(9);
                                indumentaryBooked.genre = reader.GetString(10);
                                indumentaryBooked.description = reader.GetString(11);
                                client.NAME = reader.GetString(12);
                                client.LASTNAME = reader.GetString(13);
                                client.PHONENUMBER = reader.GetString(14);
                                indumentaryBooked.oClient = client;
                                indumentariesBooked.Add(indumentaryBooked);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener las indumentarias reservadas", ex);
                    }
                }
            }
            return indumentariesBooked;
        }

        public List<BookingElectronicDto> GetElectronicsBooked()
        {
            List<BookingElectronicDto> electronicsBooked = new List<BookingElectronicDto>();
            ClientEntity client = new ClientEntity();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT br.BookingId, b.InitBooking, b.EndBooking, b.DaysBooked, b.PaymentMethod, b.TotalPrice, b.IsPaid, br.RentableId, r.Name, e.Brand, e.Model, e.SerialNumber, c.Name, c.LastName, c.PhoneNumber
                                FROM  BookingRentable br
                                INNER JOIN Electronics e ON e.RentableId = br.RentableId
                                INNER JOIN Bookings b ON b.BookingId = br.BookingId
                                INNER JOIN Rentables r ON r.RentableId = br.RentableId
                                INNER JOIN Clients c ON c.ClientId = b.ClientId
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
                                BookingElectronicDto electronicBooked = new BookingElectronicDto();
                                electronicBooked.bookingId = reader.GetInt32(0);
                                electronicBooked.initBooking = reader.GetDateTime(1);
                                electronicBooked.endBooking = reader.GetDateTime(2);
                                electronicBooked.daysBooked = reader.GetInt32(3);
                                electronicBooked.paymentMethod = reader.GetString(4);
                                electronicBooked.totalPrice = reader.GetDecimal(5);
                                electronicBooked.isPaid = reader.GetBoolean(6);
                                electronicBooked.rentableId = reader.GetInt32(7);
                                electronicBooked.rentableName = reader.GetString(8);
                                electronicBooked.brand = reader.GetString(9);
                                electronicBooked.model = reader.GetString(10);
                                electronicBooked.serialNumber = reader.GetString(11);
                                client.NAME = reader.GetString(12);
                                client.LASTNAME = reader.GetString(13);
                                client.PHONENUMBER = reader.GetString(14);
                                electronicBooked.oClient = client;
                                electronicsBooked.Add(electronicBooked);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener los dispositivos electronicos reservados", ex);
                    }
                }
            }
            return electronicsBooked;
        }




    }
}