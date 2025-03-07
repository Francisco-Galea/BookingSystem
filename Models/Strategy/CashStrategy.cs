﻿using Booking.Models.Strategy.Interface;

namespace Booking.Models.Strategy
{
    public class CashStrategy : IStrategyFinalPriceBooking
    {
        public decimal CalculateTotalPriceBooking(decimal entityCostUsage, int daysBooked)
        {
            decimal basePrice = entityCostUsage * daysBooked;
            return basePrice + (basePrice * -10 / 100);
        }

        public override string ToString()
        {
            return $"Efectivo, 10% de descuento";
        }

    }
}
