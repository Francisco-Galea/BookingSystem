using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class HouseholdApplianceEntity : RentableEntity
    {
        private int householdApplianceId;
        private string brand;
        private string model;
        private string serialNumber;
        private string usageType;

        public HouseholdApplianceEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string BRAND, string MODEL, string SERIALNUMBER, string USAGETYPE) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            this.brand = BRAND;
            this.model = MODEL;
            this.serialNumber = SERIALNUMBER;
            this.usageType = USAGETYPE;
        }

        public int HOUSEHOLDAPPLIANCEID
        {
            get { return householdApplianceId; }
            set { householdApplianceId = value; }
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
                    brand = value;
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
                    model = value;
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
                    serialNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string USAGETYPE
        {
            get { return usageType; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El tipo de uso no puede estar vacio");
                    }
                    usageType = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
