using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class ElectronicEntity : RentableEntity
    {
        private int ElectronicId;
        private string Brand;
        private string Model;
        private string SerialNumber;

        public ElectronicEntity(string BRAND, string MODEL, string SERIALNUMBER, string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            Brand = BRAND;
            Model = MODEL;
            SerialNumber = SERIALNUMBER;
        }

        public int ELECTRONICID
        {
            get { return ElectronicId; }
            set { ElectronicId = value; }
        }

        public string BRAND
        {
            get { return Brand; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("La marca no puede estar vacia");
                    }
                    Brand = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string MODEL
        {
            get { return Model; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El modelo no puede estar vacio");
                    }
                    Model = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string SERIALNUMBER
        {
            get { return SerialNumber; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El modelo no puede estar vacio");
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
