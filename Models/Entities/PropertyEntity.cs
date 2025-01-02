namespace Booking.Models.Entities
{
    public class PropertyEntity : RentableEntity
    {
        private int PropertyId;
        private string Location;

        public PropertyEntity(string LOCATION, string NAME, string DESCRIPTION, decimal MAINTENANCECOSTPERDAY, decimal COSTUSAGERPERDAY) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            this.Location = LOCATION;
        }

        public int PROPERTYID
        {
            get { return this.PropertyId; }
            set { this.PropertyId = value; }
        }

        public string LOCATION
        {
            get { return this.Location; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("La ubicacion del la propiedad no debe estar vacia");
                    }
                    this.Location = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
