using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Models.Strategy;

namespace SistemaReservas.Models
{
    public class Booking
    {
        private int BookingId {  get; set; }
        private User OUser { get; set; }
        private Vehicle OVehicle { get; set; }
        private int HoursBooked { get; set; }
        private IStrategyFinalPriceBooking StrategyFinalPriceBooking { get; set; }

    }
}
