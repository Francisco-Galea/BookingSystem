using Booking.Models.Strategy.Interface;

namespace Booking.Models.Strategy
{
    public class TransferStrategy : IStrategyFinalPriceBooking
    {
        public decimal CalculateTotalPriceBooking(decimal entityCostUsage, int daysBooked)
        {
            decimal basePrice = entityCostUsage * daysBooked;
            return basePrice + (basePrice * 0 / 100);
        }

        public override string ToString()
        {
            return $"Transferencia";
        }

    }
}
