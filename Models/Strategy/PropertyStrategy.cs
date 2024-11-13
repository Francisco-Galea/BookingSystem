using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;

namespace Booking.Models.Strategy
{
    public class PropertyStrategy : IStrategyFinalPriceBooking
    {
        public decimal CalculateTotalPriceBooking(RentableEntity rentable, int DaysBooked)
        {
            return rentable.COSTUSAGEPERDAY * DaysBooked;
        }

    }
}
