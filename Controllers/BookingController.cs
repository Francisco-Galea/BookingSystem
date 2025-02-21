using Booking.Controllers.Utility;
using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;

namespace Booking.Controllers
{
    public class BookingController
    {

        private readonly ParseController parseController = new ParseController();
        private readonly RentableEntityController rentableEntityController = new RentableEntityController();

        public void CreateBooking(int entityToRentId, DateTime initBooking, DateTime endBooking, IStrategyFinalPriceBooking strategySelected, bool isChecked)
        {
            int daysBooked = GetDaysBooked(initBooking, endBooking);
            DateOnly initBookingParsed = parseController.ParseToDateOnly(initBooking);
            DateOnly endBookingParsed = parseController.ParseToDateOnly(endBooking);
            decimal entityCostUsage = rentableEntityController.GetEntityCostUsage(entityToRentId);
            decimal finalPrice = strategySelected.CalculateTotalPriceBooking(entityCostUsage, daysBooked);
            BookingEntity booking = new BookingEntity(entityToRentId, initBookingParsed, endBookingParsed, strategySelected, finalPrice, isChecked);
        }

        public int GetDaysBooked(DateTime initBooking, DateTime endBooking)
        {
            int daysBooked;
            daysBooked = (initBooking - endBooking).Days;
            if (daysBooked <= 0)
            {
                throw new ArgumentException("El número de días reservados debe ser mayor a 0.");
            }
            return daysBooked;
        }


    }
}
