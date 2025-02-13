using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
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
            Brand = BRAND;
            Model = MODEL;
            SerialNumber = SERIALNUMBER;
            UsageType = USAGETYPE;
        }

        public int HOUSEHOLDAPPLIANCEID
        {
            get { return HouseholdApplianceId; }
            set { HouseholdApplianceId = value; }
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

        public string USAGETYPE
        {
            get { return UsageType; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El tipo de uso no puede estar vacio");
                    }
                    UsageType = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
