using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;

namespace Booking.Models.Strategy
{
    public class HouseholdApplianceStrategy : IStrategyFinalPriceBooking
    {
        decimal IStrategyFinalPriceBooking.CalculateTotalPriceBooking(RentableEntity rentable, int DaysBooked)
        {
            return rentable.COSTUSAGEPERDAY* DaysBooked;
        }

    }
}
