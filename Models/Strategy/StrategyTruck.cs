using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Models;

namespace SistemaReservas.Models.Strategy
{
    public class StrategyTruck : IStrategyFinalPriceBooking
    {
        public double CalculateTotalPriceBooking(Vehicle OVehicle, int HoursBooked)
        {
            throw new NotImplementedException();
        }
    }
}
