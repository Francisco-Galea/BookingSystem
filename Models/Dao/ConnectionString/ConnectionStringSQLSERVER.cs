﻿namespace Booking.Models.Dao.ConnectionString
{
    public class ConnectionStringSQLSERVER
    {
        private string connectionString = "Server=FRAN-GALEA\\SQLEXPRESS;Database=BookingSystem;TrustServerCertificate=true; Trusted_Connection=True;";
        #pragma warning disable CS8618 // Un campo que no acepta valores NULL 
        private static ConnectionStringSQLSERVER instance;
        #pragma warning restore CS8618 // Un campo que no acepta valores NULL 

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
            get { return this.connectionString; }
        }

    }
}
