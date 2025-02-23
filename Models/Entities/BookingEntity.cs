using Booking.Models.Strategy.Interface;

namespace Booking.Models.Entities
{
    public class BookingEntity
    {
        private int bookingId;
        private DateOnly initBooking;
        private DateOnly endBooking;
        private IStrategyFinalPriceBooking oStrategySelected;
        private int daysBooked;
        private decimal finalPrice;
        private bool isPaid;
        private bool isActiveToUpdate; //Para indicar si se puede modificar o no una reserva, como en el hotel
        private DateTime createdAt = DateTime.Now;
        private bool isDeleted; //El softDelete 

        public BookingEntity(DateOnly INITBOOKING, DateOnly ENDBOOKING, IStrategyFinalPriceBooking OSELECTEDSTRATEGY, int DAYSBOOKED, decimal FINALPRICE, bool ISPAID)
        {
            this.initBooking = INITBOOKING;
            this.endBooking = ENDBOOKING;
            this.oStrategySelected = OSELECTEDSTRATEGY;
            this.daysBooked = DAYSBOOKED;
            this.finalPrice = FINALPRICE;
            this.isPaid = ISPAID;
        }

        public int BOOKINGID
        {
            get { return this.bookingId; }
            set { this.bookingId = value; } 
        }

        public int DAYSBOOKED
        {
            get { return this.daysBooked; }
            set { this.daysBooked = value; }
        }

        public DateOnly INITBOOKING
        {
            get { return this.initBooking; }
            set { this.initBooking = value; }
        }

        public DateOnly ENDBOOKING
        {
            get { return this.endBooking; }
            set {this.endBooking = value; }
        }

        public bool ISPAID
        {
            get { return this.isPaid; }
            set { this.isPaid = value; }
        }

        public IStrategyFinalPriceBooking OSELECTEDSTRATEGY
        {
            get { return this.oStrategySelected; }
            set { this.oStrategySelected = value; }
        }

        public decimal FINALPRICE
        {
            get { return this.finalPrice; }
            set { this.finalPrice = value; }
        }

        public bool ISACTIVE
        {
            get { return this.isActiveToUpdate; }
            set { this.isActiveToUpdate = value; }
        }

    }
}
