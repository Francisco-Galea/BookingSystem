using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class PropertyEntity : RentableEntity
    {
        private int propertyId;
        private string location;

        public PropertyEntity() : base() { }

        public int PROPERTYID
        {
            get { return propertyId; }
            set { propertyId = value; }
        }

        public string LOCATION
        {
            get { return location; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("La ubicacion del la propiedad no debe estar vacia");
                    }
                    location = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
