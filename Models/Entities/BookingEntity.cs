using Booking.Models.Strategy.Interface;

namespace Booking.Models.Entities
{
    public class BookingEntity
    {
        private int BookingId;
        private RentableEntity ORentable;
        private DateOnly InitBooking;
        private DateOnly EndBooking;
        private int DaysBooked;
        private IStrategyFinalPriceBooking FinalPriceBooking;
        private bool IsPaid;
        private bool IsActive;
        private DateTime CreatedAt = DateTime.Now;
        private UserEntity CreatedBy;
        private DateTime LastUpdatedAt;
        private UserEntity? LastUpdatedBy;
        private DateTime? DeletedAt;
        private UserEntity? DeletedBy;



        public int BOOKINGID
        {
            get { return this.BookingId; }
            set { this.BookingId = value; } 
        }

        public DateOnly INITBOOKING
        {
            get { return this.InitBooking; }
            set { this.InitBooking = value; }
        }

        public DateOnly? ENDBOOKING
        {
            get { return this.EndBooking; }
            set
            {
                try
                {
                    if(value < InitBooking)
                    {
                        throw new Exception("La fecha de fin de reserva no puede ser antes de la fecha de inicio de reserva");
                    }
                    this.EndBooking = (DateOnly)value;    
                }
                catch
                {
                    throw;
                }
            }
        }

        public int DAYSBOOKED
        {
            get { return this.DaysBooked; }
            set { this.DaysBooked = value; }
        }

        public bool ISPAID
        {
            get { return this.IsPaid; }
            set { this.IsPaid = value; }
        }

        public IStrategyFinalPriceBooking FINALPRICEBOOKING
        {
            get { return this.FinalPriceBooking; }
            set { this.FinalPriceBooking = value; }
        }

        public bool ISACTIVE
        {
            get { return this.IsActive; }
            set { this.IsActive = value; }
        }

        

    }
}
