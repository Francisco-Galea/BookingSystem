namespace Booking.Models.Entities
{
    public class PropertyEntity : RentableEntity
    {
        private int PropertyId;
        private string Location;
        private int PassengerCapacity;

        public PropertyEntity(string LOCATION, int PASSENGERCAPACITY, string NAME, string DESCRIPTION, decimal MAINTENANCECOSTPERDAY, decimal COSTUSAGERPERDAY) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            this.Location = LOCATION;
            this.PassengerCapacity = PASSENGERCAPACITY;
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

        public int PASSENGERCAPACITY
        {
            get { return this.PassengerCapacity; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("La capacidad de pasajeros no puede ser menor o igual a 0");
                    }
                    this.PassengerCapacity = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
