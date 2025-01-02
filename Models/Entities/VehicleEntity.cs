namespace Booking.Models.Entities
{
    public class VehicleEntity : RentableEntity
    {
        private int VehicleId;
        private int PassengerCapacity;
        private int SerialNumber;

        public VehicleEntity(int PASSENGERCAPACITY, int SERIALNUMBER, string NAME, string DESCRIPTION, decimal MAINTENANCECOSTPERDAY, decimal COSTUSAGEPERDAY)
        : base(NAME, DESCRIPTION, COSTUSAGEPERDAY)
        {
            PassengerCapacity = PASSENGERCAPACITY;
            SerialNumber = SERIALNUMBER;
        }

        public int VEHICLEID
        {
            get { return this.VehicleId; }
            set { this.VehicleId = value; }
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
