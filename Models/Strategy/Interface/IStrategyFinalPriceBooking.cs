using Booking.Models.Entities;

namespace Booking.Models.Strategy.Interface
{
    public interface IStrategyFinalPriceBooking
    {
        decimal CalculateTotalPriceBooking(RentableEntity rentable, int DaysBooked);
    }
}
