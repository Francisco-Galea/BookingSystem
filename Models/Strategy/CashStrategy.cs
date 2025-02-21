using Booking.Models.Strategy.Interface;

namespace Booking.Models.Strategy
{
    public class CashStrategy : IStrategyFinalPriceBooking
    {
        public decimal CalculateTotalPriceBooking(decimal entityCostUsage, int daysBooked)
        {
            decimal basePrice = entityCostUsage * daysBooked;
            return basePrice + (basePrice * -10 / 100);
        }

    }
}
