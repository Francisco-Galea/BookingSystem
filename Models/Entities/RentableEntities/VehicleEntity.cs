using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class VehicleEntity : RentableEntity
    {
        private int VehicleId;
        private string Brand;
        private string Model;
        private int PassengerCapacity;
        private int SerialNumber;

        public VehicleEntity(string BRAND, string MODEL, int PASSENGERCAPACITY, int SERIALNUMBER, string NAME, string DESCRIPTION, decimal COSTUSAGEPERDAY)
        : base(NAME, DESCRIPTION, COSTUSAGEPERDAY)
        {
            Brand = BRAND;
            Model = MODEL;
            PassengerCapacity = PASSENGERCAPACITY;
            SerialNumber = SERIALNUMBER;
        }

        public int VEHICLEID
        {
            get { return VehicleId; }
            set { VehicleId = value; }
        }

        private string BRAND
        {
            get { return Brand; }
            set { Brand = value; }
        }

        private string MODEL
        {
            get { return Model; }
            set { Model = value; }
        }

        public int PASSENGERCAPACITY
        {
            get { return PassengerCapacity; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("La capacidad de pasajeros no puede ser menor o igual a 0");
                    }
                    PassengerCapacity = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public int SERIALNUMBER
        {
            get { return SerialNumber; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("La capacidad de pasajeros no puede ser menor o igual a 0");
                    }
                    SerialNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
