using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;

namespace Booking.Models.Strategy
{
    public class CreditCardStrategy : IStrategyFinalPriceBooking
    {
        public decimal CalculateTotalPriceBooking(RentableEntity rentable, int DaysBooked)
        {
            decimal totalPrice = rentable.COSTUSAGEPERDAY * DaysBooked;
            return totalPrice * 1.35m;
        }

    }
}
