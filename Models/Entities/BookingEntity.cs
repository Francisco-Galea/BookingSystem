using Booking.Models.Strategy.Interface;

namespace Booking.Models.Entities
{
    public class BookingEntity
    {
        private int bookingId;
        private RentableEntity oRentable;
        private DateOnly initBooking;
        private DateOnly endBooking;
        private int daysBooked;
        private IStrategyFinalPriceBooking oFinalPriceBooking;
        private bool isPaid;
        private bool isActiveToUpdate; //Para indicar si se puede modificar o no una reserva, como en el hotel
        private DateTime createdAt = DateTime.Now;
        private bool isDeleted; //El softDelete 

        public int BOOKINGID
        {
            get { return this.bookingId; }
            set { this.bookingId = value; } 
        }

        public DateOnly INITBOOKING
        {
            get { return this.initBooking; }
            set { this.initBooking = value; }
        }

        public DateOnly? ENDBOOKING
        {
            get { return this.endBooking; }
            set
            {
                try
                {
                    if(value < initBooking)
                    {
                        throw new Exception("La fecha de fin de reserva no puede ser antes de la fecha de inicio de reserva");
                    }
                    this.endBooking = (DateOnly)value;    
                }
                catch
                {
                    throw;
                }
            }
        }

        public int DAYSBOOKED
        {
            get { return this.daysBooked; }
            set { this.daysBooked = value; }
        }

        public bool ISPAID
        {
            get { return this.isPaid; }
            set { this.isPaid = value; }
        }

        public IStrategyFinalPriceBooking FINALPRICEBOOKING
        {
            get { return this.oFinalPriceBooking; }
            set { this.oFinalPriceBooking = value; }
        }

        public bool ISACTIVE
        {
            get { return this.isActiveToUpdate; }
            set { this.isActiveToUpdate = value; }
        }

        

    }
}
