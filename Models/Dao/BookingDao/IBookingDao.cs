﻿using Boocking.Models.Entities.RentableEntities;
using Booking.Dtos.BookedEntities;
using Booking.Dtos.CoreDataBooking;
using Booking.Models.Dao.GenericDaoInterface;
using Booking.Models.Entities;

namespace Booking.Models.Dao.BookingDao
{
    public interface IBookingDao
    {
        bool CheckAvailabilityForEntity(int entityToRentId, DateOnly initBooking, DateOnly endBooking);
        void InsertEntity(BookingEntity booking, int entityToRent);
        BookingEntity GetEntityById(int bookingId);
        void DeleteEntity(int bookingId);
        void UpdateEntity(int bookingId, BookingEntity booking, int entityToRentId);
        List<BookingPropertyDTO> GetPropertiesBooked();
        List<BookingVehicleDTO> GetVehiclesBooked();
        BookingCoreDataDto GetBookingCoreData(int bookingId);
        bool CheckAvailabilityForExistingBooking(int entityToRentId, int currentBookingId, DateOnly initBooking, DateOnly endBooking);
    }
}
