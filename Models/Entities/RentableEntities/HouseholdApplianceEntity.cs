
namespace Booking.Models.Entities
{
    public class HouseholdApplianceEntity : RentableEntity
    {
        private int HouseholdApplianceId;
        private string Brand;
        private string Model;
        private string SerialNumber;
        private string UsageType;

        public HouseholdApplianceEntity(string BRAND, string MODEL, string SERIALNUMBER, string USAGETYPE, string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            this.Brand = BRAND;
            this.Model = MODEL;
            this.SerialNumber = SERIALNUMBER;
            this.UsageType = USAGETYPE;
        }

        public int HOUSEHOLDAPPLIANCEID
        {
            get { return this.HouseholdApplianceId; }
            set { this.HouseholdApplianceId = value; }
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

        public string USAGETYPE
        {
            get { return this.UsageType; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El tipo de uso no puede estar vacio");
                    }
                    this.UsageType = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
