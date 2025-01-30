namespace Booking.Models.Entities
{
    public class ElectronicEntity : RentableEntity
    {
        private int ElectronicId;
        private string Brand;
        private string Model;
        private string SerialNumber;

        public ElectronicEntity(string BRAND, string MODEL, string SERIALNUMBER, string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY ) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            this.Brand = BRAND;
            this.Model = MODEL;
            this.SerialNumber = SERIALNUMBER;   
        }

        public int ELECTRONICID
        {
            get { return this.ElectronicId; }
            set { this.ElectronicId = value; }
        }

        public string BRAND
        {
            get { return this.Brand; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("La marca no puede estar vacia");
                    }
                    this.Brand = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string MODEL
        {
            get { return this.Model; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El modelo no puede estar vacio");
                    }
                    this.Model = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string SERIALNUMBER
        {
            get { return this.SerialNumber; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El modelo no puede estar vacio");
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
