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


        public List<BookingVehicleDTO> GetVehicleBookings()
        {
            return bookingDao.GetVehiclesBooked();
        }

        public List<BookingPropertyDTO> GetPropertyBookings()
        {
            return bookingDao.GetPropertiesBooked();
        }

        public BookingEntity GetBookingById(int bookingId)
        {
            return bookingDao.GetEntityById(bookingId);
        }

        public void DeleteBooking(int bookingId)
        {
            bookingDao.DeleteEntity(bookingId);
        }

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

        public BookingCoreDataDto GetBookingCoreData(int bookingId)
        {
            return bookingDao.GetBookingCoreData(bookingId);
        }

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

    }
}
