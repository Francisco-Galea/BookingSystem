using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Boocking.Models.Dao.VehicleDao
{
    public class VehicleDaoSQLSERVER : IVehicleDao
    {

        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void InsertEntity(VehicleEntity vehicle)
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
                    rentableCommand.Parameters.AddWithValue("@Name", vehicle.NAME);
                    rentableCommand.Parameters.AddWithValue("@Description", vehicle.DESCRIPTION);
                    rentableCommand.Parameters.AddWithValue("@CostUsagePerDay", vehicle.COSTUSAGEPERDAY);

                    var rentableIdResult = rentableCommand.ExecuteScalar();
                    int rentableId = Convert.ToInt32(rentableIdResult); // 

                    string vehicleQuery = @"
                    INSERT INTO Vehicles (RentableId, Brand, Model, PassengerCapacity, SerialNumber)
                    VALUES (@RentableId, @Brand, @Model, @PassengerCapacity, @SerialNumber)";

                    SqlCommand vehicleCommand = new SqlCommand(vehicleQuery, connection, transaction);
                    vehicleCommand.Parameters.AddWithValue("@RentableId", rentableId); 
                    vehicleCommand.Parameters.AddWithValue("@Brand", vehicle.BRAND);
                    vehicleCommand.Parameters.AddWithValue("@Model", vehicle.MODEL);
                    vehicleCommand.Parameters.AddWithValue("@PassengerCapacity", vehicle.PASSENGERCAPACITY);
                    vehicleCommand.Parameters.AddWithValue("@SerialNumber", vehicle.SERIALNUMBER);

                    vehicleCommand.ExecuteNonQuery(); 

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al crear el vehiculo", ex);
                }
            }
        }


        public VehicleEntity GetEntityById(int rentableId)
        {
            VehicleEntity vehicleReturned = null; 

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT v.VehicleId, r.Name, r.Description, r.CostUsagePerDay, v.Brand, v.Model, v.SerialNumber, v.PassengerCapacity 
                                FROM Vehicles v
                                INNER JOIN Rentables r ON v.RentableId = r.RentableId
                                WHERE r.RentableId = @RentableId AND r.IsDeleted = 0";

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
                                vehicleReturned = new VehicleEntity(); 
                                vehicleReturned.VEHICLEID = reader.GetInt32(0);
                                vehicleReturned.NAME = reader.GetString(1);
                                vehicleReturned.DESCRIPTION = reader.GetString(2);
                                vehicleReturned.COSTUSAGEPERDAY = reader.GetDecimal(3);
                                vehicleReturned.BRAND = reader.GetString(4);
                                vehicleReturned.MODEL = reader.GetString(5);
                                vehicleReturned.SERIALNUMBER = reader.GetString(6);
                                vehicleReturned.PASSENGERCAPACITY = reader.GetInt32(7);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener el vehículo", ex);
                    }
                }
            }
            return vehicleReturned; 
        }

        public List<VehicleEntity> GetAllEntities()
        {
            List<VehicleEntity> vehicles = new List<VehicleEntity>();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"
                                SELECT r.RentableId, r.Name, r.Description, r.CostUsagePerDay, v.Brand, v.Model, v.SerialNumber, v.PassengerCapacity 
                                FROM Vehicles v
                                INNER JOIN Rentables r ON v.RentableId = r.RentableId
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
                                VehicleEntity vehicle = new VehicleEntity();
                                vehicle.VEHICLEID = reader.GetInt32(0);
                                vehicle.NAME = reader.GetString(1);
                                vehicle.DESCRIPTION = reader.GetString(2);
                                vehicle.COSTUSAGEPERDAY = reader.GetDecimal(3);
                                vehicle.BRAND = reader.GetString(4);
                                vehicle.MODEL = reader.GetString(5);
                                vehicle.SERIALNUMBER = reader.GetString(6);
                                vehicle.PASSENGERCAPACITY = reader.GetInt32(7);

                                vehicles.Add(vehicle);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener los vehículos", ex);
                    }
                }
            }

            return vehicles;
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
                    throw new Exception("Error al realizar el borrado lógico del vehículo", ex);
                }
            }
        }

        public void UpdateEntity(int rentableId, VehicleEntity vehicle)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updateVehicleQuery = @"
                                                UPDATE Vehicles SET 
                                                Brand = @Brand,
                                                Model = @Model,
                                                PassengerCapacity = @PassengerCapacity,
                                                SerialNumber = @SerialNumber
                                                WHERE RentableId = @RentableId
                                                ";

                    SqlCommand updateVehicleCommand = new SqlCommand(updateVehicleQuery, connection, transaction);
                    updateVehicleCommand.Parameters.AddWithValue("@RentableId", rentableId);
                    updateVehicleCommand.Parameters.AddWithValue("@Brand", vehicle.BRAND);
                    updateVehicleCommand.Parameters.AddWithValue("@Model", vehicle.MODEL);
                    updateVehicleCommand.Parameters.AddWithValue("@PassengerCapacity", vehicle.PASSENGERCAPACITY);
                    updateVehicleCommand.Parameters.AddWithValue("@SerialNumber", vehicle.SERIALNUMBER);
                    updateVehicleCommand.ExecuteNonQuery();

                    string updateRentableQuery = @"
                                                 UPDATE Rentables SET 
                                                 Name = @Name,
                                                 Description = @Description,
                                                 CostUsagePerDay = @CostUsagePerDay
                                                 WHERE RentableId = @RentableId
                                                 ";

                    SqlCommand updateRentableCommand = new SqlCommand(updateRentableQuery, connection, transaction);
                    updateRentableCommand.Parameters.AddWithValue("@RentableId", rentableId);
                    updateRentableCommand.Parameters.AddWithValue("@Name", vehicle.NAME);
                    updateRentableCommand.Parameters.AddWithValue("@Description", vehicle.DESCRIPTION);
                    updateRentableCommand.Parameters.AddWithValue("@CostUsagePerDay", vehicle.COSTUSAGEPERDAY);
                    updateRentableCommand.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al actualizar el vehículo", ex);
                }
            }
        }
    }
}
