using Boocking.Models.Entities;
using Booking.Dtos.BookedEntities;
using Booking.Dtos.CoreDataBooking;
using Booking.Models.Dao.BookingDao;
using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;
using Booking.Utility;
using Microsoft.Data.SqlClient;

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
                booking.FINALPRICE = finalPrice;
                booking.DAYSBOOKED = daysBooked;
                booking.OCLIENT = client;
                booking.OSELECTEDSTRATEGY = strategySelected;
                booking.ISPAID = isPaid;
                bookingDao.InsertEntity(booking, entityToRentId);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al agregar la reserva: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar la reserva.", ex);
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
                booking.FINALPRICE = finalPrice;
                booking.DAYSBOOKED = daysBooked;
                booking.OCLIENT = client;
                booking.OSELECTEDSTRATEGY = strategySelected;
                booking.ISPAID = isPaid;
                bookingDao.UpdateEntity(bookingId, booking, entityToRentId);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Error al actualizar la reserva: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar la reserva.", ex);
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

        public List<BookingIndumentaryDto> GetIndumentaryBookings()
        {
            return bookingDao.GetIndumentariesBooked();
        }

        public List<BookingElectronicDto> GetElectronicBookings()
        {
            return bookingDao.GetElectronicsBooked();
        }


        #endregion

        #region Delete booking
        public void DeleteBooking(int bookingId, DialogResult result)
        {
            try
            {
                if(result == DialogResult.Yes)
                {
                    bookingDao.DeleteEntity(bookingId);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el cliente.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al eliminar el cliente.", ex);
            }
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
