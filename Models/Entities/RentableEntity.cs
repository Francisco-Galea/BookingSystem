namespace Booking.Models.Entities
{
    public abstract class RentableEntity
    {
        private int RentableId;
        private string Name;
        private string Description;
        private decimal CostUsagePerDay;
        private bool isDeleted;

        public RentableEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY)
        {
            this.Name = NAME;
            this.Description = DESCRIPTION;
            this.CostUsagePerDay = COSTUSAGERPERDAY;
        }

        public int RENTABLEID
        {
            get { return this.RentableId; }
            set { this.RentableId = value; }
        }

        public string NAME
        {
            get { return this.Name; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("El nombre del objeto no puede estar vacio");
                    }
                    this.Name = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public string DESCRIPTION
        {
            get { return this.Description; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("La descripcion del objeto no puede estar vacio");
                    }
                    this.Description = value;
                }
                catch
                {
                    throw;
                }
            }
        }

        public decimal COSTUSAGEPERDAY
        {
            get { return this.CostUsagePerDay; }
            set
            {
                try
                {
                    if(value <= 0)
                    {
                        throw new Exception("El costo de uso por dia no puede ser 0");
                    }
                    this.CostUsagePerDay = value;
                }
                catch
                {
                    throw;
                }
            }
        }

    }
}
