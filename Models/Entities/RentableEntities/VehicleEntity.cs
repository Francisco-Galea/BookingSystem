using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class VehicleEntity : RentableEntity
    {
        private int vehicleId;
        private string brand;
        private string model;
        private int passengerCapacity;
        private int serialNumber;

        public VehicleEntity(string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY, string BRAND, string MODEL, int PASSENGERCAPACITY, int SERIALNUMBER)
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
            set { vehicleId = value; }
        }

        private string BRAND
        {
            get { return brand; }
            set { brand = value; }
        }

        private string MODEL
        {
            get { return model; }
            set { model = value; }
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
                    passengerCapacity = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public int SERIALNUMBER
        {
            get { return serialNumber; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("La capacidad de pasajeros no puede ser menor o igual a 0");
                    }
                    serialNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
