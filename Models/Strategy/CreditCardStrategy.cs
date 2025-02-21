using Booking.Models.Strategy.Interface;

namespace Booking.Models.Strategy
{
    public class CreditCardStrategy : IStrategyFinalPriceBooking
    {
        public decimal CalculateTotalPriceBooking(decimal entityCostUsage, int daysBooked)
        {
            decimal basePrice = entityCostUsage * daysBooked;
            return basePrice + (basePrice * 40 / 100);
        }

    }
}
