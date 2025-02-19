using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;
using Microsoft.Data.SqlClient;

namespace Boocking.Models.Dao.VehicleDao
{
    public class VehicleDaoSQLSERVER : IVehicleDao
    {
        private readonly ConnectionStringSQLSERVER connectionStringSQLSERVER = ConnectionStringSQLSERVER.getInstance();

        public void CreateVehicle(VehicleEntity vehicle)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "INSERT INTO Vehicle (Name, Description, CostUsagePerDay, Brand, Model, PassengerCapacity, SerialNumber) VALUES (@Name, @Description, @CostUsagePerDay, @Brand, @Model, @PassengerCapacity, @SerialNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", vehicle.NAME);
                    command.Parameters.AddWithValue("@Description", vehicle.DESCRIPTION);
                    command.Parameters.AddWithValue("@CostUsagePerDay", vehicle.COSTUSAGEPERDAY);
                    command.Parameters.AddWithValue("@Brand", vehicle.BRAND);
                    command.Parameters.AddWithValue("@Model", vehicle.MODEL);
                    command.Parameters.AddWithValue("@PassengerCapacity", vehicle.PASSENGERCAPACITY);
                    command.Parameters.AddWithValue("@SerialNumber", vehicle.SERIALNUMBER);

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

        public VehicleEntity GetVehicleById(int vehicleId)
        {
            VehicleEntity vehicleReturned = new VehicleEntity();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "SELECT VehicleId, Name, Description, CostUsagePerDay, Brand, Model, SerialNumber, PassengerCapacity FROM Vehicle WHERE VehicleId = @vehicleId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@vehicleId", vehicleId);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
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
                    catch
                    {

                    }
                }
            }
            return vehicleReturned;
        }

        public List<VehicleEntity> GetAllVehicles()
        {
            List<VehicleEntity> vehicles = new List<VehicleEntity>();

            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "SELECT VehicleId, Name, Description, CostUsagePerDay, Brand, Model, SerialNumber, PassengerCapacity FROM Vehicle WHERE IsDeleted = 0";

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
                    catch
                    {

                    }
                }
            }
            return vehicles;
        }

        public void DeleteVehicle(int vehicleId)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = "UPDATE Vehicle SET IsDeleted = 1 WHERE VehicleId = @VehicleId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VehicleId", vehicleId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception("No se encontró el producto para borrar o ya está borrado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al realizar el borrado lógico del producto", ex);
                    }
                }
            }
        }

        public void UpdateVehicle(int vehicleId, VehicleEntity vehicle)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringSQLSERVER.ConnectionString))
            {
                string query = @"UPDATE Vehicle SET 
                                 Name = @Name,
                                 Description = @Description,
                                 CostUsagePerDay = @CostUsagePerDay,
                                 Brand = @Brand,
                                 Model = @Model,
                                 SerialNumber = @SerialNumber,
                                 PassengerCapacity = @PassengerCapacity
                                 WHERE VehicleId = @VehicleId
                                ";
                
                using (SqlCommand command = new SqlCommand (query, connection))
                {
                    command.Parameters.AddWithValue("@VehicleId", vehicleId);
                    command.Parameters.AddWithValue("@Name", vehicle.NAME);
                    command.Parameters.AddWithValue("@Description", vehicle.DESCRIPTION);
                    command.Parameters.AddWithValue("@CostUsagePerDay", vehicle.COSTUSAGEPERDAY);
                    command.Parameters.AddWithValue("@Brand", vehicle.BRAND);
                    command.Parameters.AddWithValue("@Model", vehicle.MODEL);
                    command.Parameters.AddWithValue("@PassengerCapacity", vehicle.PASSENGERCAPACITY);
                    command.Parameters.AddWithValue("@SerialNumber", vehicle.SERIALNUMBER);

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
