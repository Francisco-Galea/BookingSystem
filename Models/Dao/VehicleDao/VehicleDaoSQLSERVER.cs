using Boocking.Models.Entities.RentableEntities;
using Booking.Models.Dao.ConnectionString;
using Booking.Models.Entities;
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

        public void DeleteVehicle(int VehicleId)
        {
            throw new NotImplementedException();
        }

        public List<VehicleEntity> GetAllVehicles()
        {
            throw new NotImplementedException();
        }

        public VehicleEntity GetVehicleById(int VehicleId)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicle(int VehicleId, VehicleEntity vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
