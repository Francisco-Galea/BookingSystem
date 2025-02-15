using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class VehicleEntity : RentableEntity
    {
        private int vehicleId;
        private string brand;
        private string model;
        private int passengerCapacity;
        private string serialNumber;

        public VehicleEntity(string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY, string BRAND, string MODEL, int PASSENGERCAPACITY, string SERIALNUMBER)
        : base(NAME, DESCRIPTION, COSTUSAGEPERDAY)
        {
            this.brand = BRAND;
            this.model = MODEL;
            this.passengerCapacity = PASSENGERCAPACITY;
            this.serialNumber = SERIALNUMBER;
        }

        public int VEHICLEID
        {
            get { return vehicleId; }
            set { this.vehicleId = value; }
        }

        private string BRAND
        {
            get { return brand; }
            set { this.brand = value; }
        }

        private string MODEL
        {
            get { return model; }
            set { this.model = value; }
        }

        public int PASSENGERCAPACITY
        {
            get { return passengerCapacity; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("La capacidad de pasajeros no puede ser menor o igual a 0");
                    }
                    this.passengerCapacity = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string SERIALNUMBER
        {
            get { return serialNumber; }
            set { this.serialNumber = value; }
        }

    }
}
