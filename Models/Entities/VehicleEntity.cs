namespace Booking.Models.Entities
{
    public class VehicleEntity : RentableEntity
    {
        private int VehicleId;
        private string Brand;
        private string Model;
        private int PassengerCapacity;
        private int SerialNumber;

        public VehicleEntity(string BRAND, string MODEL, int PASSENGERCAPACITY, int SERIALNUMBER, string NAME, string DESCRIPTION, decimal MAINTENANCECOSTPERDAY, decimal COSTUSAGEPERDAY)
        : base(NAME, DESCRIPTION, COSTUSAGEPERDAY)
        {
            Brand = BRAND;
            Model = MODEL;
            PassengerCapacity = PASSENGERCAPACITY;
            SerialNumber = SERIALNUMBER;
        }

        public int VEHICLEID
        {
            get { return this.VehicleId; }
            set { this.VehicleId = value; }
        }

        private string BRAND
        {
            get { return this.Brand; }
            set { this.Brand = value; }
        }

        private string MODEL
        {
            get { return this.Model; }
            set { this.Model = value; }
        }

        public int PASSENGERCAPACITY
        {
            get { return this.PassengerCapacity; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("La capacidad de pasajeros no puede ser menor o igual a 0");
                    }
                    this.PassengerCapacity = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public int SERIALNUMBER
        {
            get { return this.SerialNumber; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("La capacidad de pasajeros no puede ser menor o igual a 0");
                    }
                    this.SerialNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
