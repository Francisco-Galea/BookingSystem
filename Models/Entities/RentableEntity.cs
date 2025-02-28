namespace Booking.Models.Entities
{
    public abstract class RentableEntity
    {
        private int rentableId;
        private string name;
        private string description;
        private decimal costUsagePerDay;
        private bool isDeleted;

        public RentableEntity() { }

        public RentableEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY)
        {
            this.NAME = NAME;
            this.DESCRIPTION = DESCRIPTION;
            this.COSTUSAGEPERDAY = COSTUSAGERPERDAY;
        }

        public int RENTABLEID
        {
            get { return this.rentableId; }
            set { this.rentableId = value; }
        }

        public string NAME
        {
            get { return this.name; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El nombre de articulo no puede estar vacio");
                    }
                    this.name = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string DESCRIPTION
        {
            get { return this.description; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("La descripcion del articulo no puede estar vacio");
                    }
                    this.description = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public decimal COSTUSAGEPERDAY
        {
            get { return this.costUsagePerDay; }
            set
            {
                try
                {
                    if(value <= 0)
                    {
                        throw new Exception("La tarifa diaria no puede ser 0");
                    }
                    this.costUsagePerDay = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
