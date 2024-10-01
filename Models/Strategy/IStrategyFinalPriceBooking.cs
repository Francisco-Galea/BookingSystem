using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Models;

namespace SistemaReservas.Models.Strategy
{
    public interface IStrategyFinalPriceBooking
    {
        double CalculateTotalPriceBooking(Vehicle OVehicle, int HoursBooked);
    }
}
