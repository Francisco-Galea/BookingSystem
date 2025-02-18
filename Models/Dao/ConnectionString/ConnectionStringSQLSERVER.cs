namespace Booking.Models.Dao.ConnectionString
{
    public class ConnectionStringSQLSERVER
    {
        private string connectionString = "Server=FRAN-GALEA\\SQLEXPRESS;Database=BookingSystem;TrustServerCertificate=true; Trusted_Connection=True;";
        private static ConnectionStringSQLSERVER instance;

        private ConnectionStringSQLSERVER() { }

        public static ConnectionStringSQLSERVER getInstance()
        {
            if (instance == null)
            {
                instance = new ConnectionStringSQLSERVER();
            }
            return instance;
        }

        public string ConnectionString
        {
            get { return connectionString; }
        }

    }
}
