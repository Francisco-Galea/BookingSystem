using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class PropertyEntity : RentableEntity
    {
        private int PropertyId;
        private string Location;

        public PropertyEntity(string LOCATION, string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            Location = LOCATION;
        }

        public int PROPERTYID
        {
            get { return PropertyId; }
            set { PropertyId = value; }
        }

        public string LOCATION
        {
            get { return Location; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("La ubicacion del la propiedad no debe estar vacia");
                    }
                    Location = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
