using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;

namespace Booking.Models.Strategy
{
    public class TransferStrategy : IStrategyFinalPriceBooking
    {
        public decimal CalculateTotalPriceBooking(RentableEntity rentable, int DaysBooked)
        {
            return rentable.COSTUSAGEPERDAY * DaysBooked;
        }

    }
}
