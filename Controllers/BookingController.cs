using Boocking.Models.Entities;
using Booking.Dtos.BookedEntities;
using Booking.Dtos.CoreDataBooking;
using Booking.Models.Dao.BookingDao;
using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;
using Booking.Utility;

namespace Booking.Controllers
{
    public class BookingController
    {

        private readonly RentableEntityController rentableEntityController = new RentableEntityController();
        private readonly IBookingDao bookingDao = new BookingDaoSQLSERVER();

        #region Create Booking
        public void CreateBooking(int entityToRentId, DateTime initBooking, DateTime endBooking, ClientEntity client,  IStrategyFinalPriceBooking strategySelected, bool isPaid)
        {
            try
            {
                int daysBooked = 0;
                daysBooked += GetDaysBooked(initBooking, endBooking);
                DateOnly initBookingParsed = ParseController.ParseToDateOnly(initBooking);
                DateOnly endBookingParsed = ParseController.ParseToDateOnly(endBooking);
                decimal entityCostUsage = rentableEntityController.GetEntityCostUsage(entityToRentId);
                decimal finalPrice = strategySelected.CalculateTotalPriceBooking(entityCostUsage, daysBooked);
                BookingEntity booking = new BookingEntity();
                booking.INITBOOKING = initBookingParsed;
                booking.ENDBOOKING = endBookingParsed;
                booking.DAYSBOOKED = daysBooked;
                booking.OCLIENT = client;
                booking.OSELECTEDSTRATEGY = strategySelected;
                booking.ISPAID = isPaid;
                bookingDao.InsertEntity(booking, entityToRentId);
            }
            catch
            {

            }
        }
        #endregion

        #region Update Booking
        public void UpdateBooking(int bookingId, int entityToRentId, DateTime initBooking, DateTime endBooking, ClientEntity client, IStrategyFinalPriceBooking strategySelected, bool isPaid)
        {
            try
            {
                int daysBooked = 0;
                daysBooked += GetDaysBooked(initBooking, endBooking);
                DateOnly initBookingParsed = ParseController.ParseToDateOnly(initBooking);
                DateOnly endBookingParsed = ParseController.ParseToDateOnly(endBooking);
                decimal entityCostUsage = rentableEntityController.GetEntityCostUsage(entityToRentId);
                decimal finalPrice = strategySelected.CalculateTotalPriceBooking(entityCostUsage, daysBooked);
                BookingEntity booking = new BookingEntity();
                booking.INITBOOKING = initBookingParsed;
                booking.ENDBOOKING = endBookingParsed;
                booking.DAYSBOOKED = daysBooked;
                booking.OCLIENT = client;
                booking.OSELECTEDSTRATEGY = strategySelected;
                booking.ISPAID = isPaid;
                bookingDao.UpdateEntity(bookingId, booking, entityToRentId);
            }
            catch
            {

            }
        }
        #endregion

        #region Get Bookings methods
        public BookingCoreDataDto GetBookingCoreData(int bookingId)
        {
            return bookingDao.GetBookingCoreData(bookingId);
        }

        public List<BookingVehicleDTO> GetVehicleBookings()
        {
            return bookingDao.GetVehiclesBooked();
        }

        
        public List<BookingPropertyDTO> GetPropertyBookings()
        {
            return bookingDao.GetPropertiesBooked();
        }
        #endregion

        #region Delete booking
        public void DeleteBooking(int bookingId)
        {
            bookingDao.DeleteEntity(bookingId);
        }
        #endregion

        #region Utility Methods for Bookings
        public bool CheckAvailabilityForExistingBooking(int entityToRentId, int currentBookingId, DateTime initBooking, DateTime endBooking)
        {
            try
            {
                DateOnly initBookingParsed = ParseController.ParseToDateOnly(initBooking);
                DateOnly endBookingParsed = ParseController.ParseToDateOnly(endBooking);
                return bookingDao.CheckAvailabilityForExistingBooking(entityToRentId, currentBookingId, initBookingParsed, endBookingParsed);
            }
            catch
            {
                throw new Exception("Error al verificar disponibilidad");
            }
        }

        public bool CheckEntityAvailability(int entityToRentId, DateTime initBooking, DateTime endBooking)
        {
            try
            {
                DateOnly initBookingParsed = ParseController.ParseToDateOnly(initBooking);
                DateOnly endBookingParsed = ParseController.ParseToDateOnly(endBooking);
                return bookingDao.CheckAvailabilityForEntity(entityToRentId, initBookingParsed, endBookingParsed);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar disponibilidad", ex);
            }
        }

        public int GetDaysBooked(DateTime initBooking, DateTime endBooking)
        {
            int daysBooked = 1;
            daysBooked += (endBooking - initBooking).Days;
            if (daysBooked <= 0)
            {
                throw new ArgumentException("El número de días reservados debe ser mayor a 0.");
            }
            return daysBooked;
        }
        #endregion

    }
}
