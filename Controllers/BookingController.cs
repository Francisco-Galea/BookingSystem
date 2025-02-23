﻿using Boocking.Models.Entities.RentableEntities;
using Booking.Controllers.Utility;
using Booking.Dtos;
using Booking.Models.Dao.BookingDao;
using Booking.Models.Entities;
using Booking.Models.Strategy.Interface;

namespace Booking.Controllers
{
    public class BookingController
    {

        private readonly RentableEntityController rentableEntityController = new RentableEntityController();
        private readonly IBookingDao bookingDao = new BookingDaoSQLSERVER();

        public void CreateBooking(int entityToRentId, DateTime initBooking, DateTime endBooking, IStrategyFinalPriceBooking strategySelected, bool isChecked)
        {
            try
            {
                int daysBooked = 0;
                daysBooked += GetDaysBooked(initBooking, endBooking);
                DateOnly initBookingParsed = ParseController.ParseToDateOnly(initBooking);
                DateOnly endBookingParsed = ParseController.ParseToDateOnly(endBooking);
                decimal entityCostUsage = rentableEntityController.GetEntityCostUsage(entityToRentId);
                decimal finalPrice = strategySelected.CalculateTotalPriceBooking(entityCostUsage, daysBooked);
                BookingEntity booking = new BookingEntity(initBookingParsed, endBookingParsed, strategySelected, daysBooked, finalPrice, isChecked);
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

        public void UpdateBooking(int bookingId, int entityToRentId, DateTime initBooking, DateTime endBooking, IStrategyFinalPriceBooking strategySelected, bool isChecked)
        {

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


    }
}
