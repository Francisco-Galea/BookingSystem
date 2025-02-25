using Boocking.Models.Entities;
using Booking.Models.Strategy.Interface;

namespace Booking.Models.Entities
{
    public class BookingEntity
    {
        private int bookingId;
        private DateOnly initBooking;
        private DateOnly endBooking;
        private ClientEntity oClient;
        private IStrategyFinalPriceBooking oStrategySelected;
        private int daysBooked;
        private decimal finalPrice;
        private bool isPaid;
        private DateTime createdAt = DateTime.Now;
        private bool isDeleted;


        #pragma warning disable CS8618 
        public BookingEntity() { }
        #pragma warning restore CS8618 

        public int BOOKINGID
        {
            get { return this.bookingId; }
            set { this.bookingId = value; }
        }

        public int DAYSBOOKED
        {
            get { return this.daysBooked; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Los días reservados deben ser mayores a 0.");
                }
                this.daysBooked = value;
            }
        }

        public DateOnly INITBOOKING
        {
            get { return this.initBooking; }
            set { this.initBooking = value; }
        }

        public DateOnly ENDBOOKING
        {
            get { return this.endBooking; }
            set
            {
                if (value < this.initBooking)
                {
                    throw new ArgumentException("La fecha de finalización no puede ser anterior a la fecha de inicio.");
                }
                this.endBooking = value;
            }
        }

        public ClientEntity OCLIENT
        {
            get { return this.oClient; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("El cliente no puede ser nulo.");
                }
                this.oClient = value;
            }
        }

        public bool ISPAID
        {
            get { return this.isPaid; }
            set { this.isPaid = value; }
        }

        public IStrategyFinalPriceBooking OSELECTEDSTRATEGY
        {
            get { return this.oStrategySelected; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("La estrategia de precio no puede ser nula.");
                }
                this.oStrategySelected = value;
            }
        }

        public decimal FINALPRICE
        {
            get { return this.finalPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio final no puede ser negativo.");
                }
                this.finalPrice = value;
            }
        }

    }
}
