using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class ElectronicEntity : RentableEntity
    {
        private int electronicId;
        private string brand;
        private string model;
        private string serialNumber;

        public ElectronicEntity() : base() { }

        public int ELECTRONICID
        {
            get { return electronicId; }
            set { this.electronicId = value; }
        }

        public string BRAND
        {
            get { return brand; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("La marca no puede estar vacia");
                    }
                    this.brand = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string MODEL
        {
            get { return model; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El modelo no puede estar vacio");
                    }
                    this.model = value;
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
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El modelo no puede estar vacio");
                    }
                    this.serialNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
