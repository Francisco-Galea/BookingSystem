using Booking.Controllers.Utility;
using Booking.Models.Dao.BookingDao;
using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;

namespace Booking.Controllers
{
    public class BookingController
    {

        private readonly ParseController parseController = new ParseController();
        private readonly RentableEntityController rentableEntityController = new RentableEntityController();
        private readonly IBookingDao bookingDao = new BookingDaoSQLSERVER();

        public void CreateBooking(int entityToRentId, DateTime initBooking, DateTime endBooking, IStrategyFinalPriceBooking strategySelected, bool isChecked)
        {
            try
            {
                int daysBooked = GetDaysBooked(initBooking, endBooking);
                DateOnly initBookingParsed = parseController.ParseToDateOnly(initBooking);
                DateOnly endBookingParsed = parseController.ParseToDateOnly(endBooking);
                decimal entityCostUsage = rentableEntityController.GetEntityCostUsage(entityToRentId);
                decimal finalPrice = strategySelected.CalculateTotalPriceBooking(entityCostUsage, daysBooked);
                BookingEntity booking = new BookingEntity(entityToRentId, initBookingParsed, endBookingParsed, strategySelected, daysBooked, finalPrice, isChecked);
                bookingDao.InsertEntity(booking);
            }
            catch
            {

            }
        }

        public bool CheckEntityAvailability(int entityToRentId, DateTime initBooking, DateTime endBooking)
        {
            try
            {
                DateOnly initBookingParsed = parseController.ParseToDateOnly(initBooking);
                DateOnly endBookingParsed = parseController.ParseToDateOnly(endBooking);
                return bookingDao.CheckAvailabilityForEntity(entityToRentId, initBookingParsed, endBookingParsed);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar disponibilidad", ex);
            }
        }













        public List<BookingEntity> GetAllBookings()
        {
            return bookingDao.GetAllEntities();
        }

        public BookingEntity GetBookingById(int bookingId)
        {
            return bookingDao.GetEntityById(bookingId);
        }

        public void DeleteBooking(int bookingId)
        {
            bookingDao.DeleteEntity(bookingId);
        }

        public void UpdateBooking(int bookingId, int entityToRentId, DateTime initBooking, DateTime endBooking, IStrategyFinalPriceBooking strategySelected, bool isChecked)
        {

        }

        public int GetDaysBooked(DateTime initBooking, DateTime endBooking)
        {
            int daysBooked;
            daysBooked = (endBooking - initBooking).Days;
            if (daysBooked <= 0)
            {
                throw new ArgumentException("El número de días reservados debe ser mayor a 0.");
            }
            return daysBooked;
        }


    }
}
