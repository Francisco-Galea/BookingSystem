using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boocking.Views.ItemsView.RentableObjectsView;
using Boocking.Views.RentableObjectsView;
using Booking.Models.Entities;

namespace Boocking.Controllers
{
    public class BookingController
    {

        public void CreateBooking(string selectedEntity)
        {
            try
            {
            
            switch (selectedEntity)
            {
                case "Vehiculo":
                    VehicleView vehicleView = new VehicleView();
                    vehicleView.ShowDialog();
                    break;

                case "Propiedad":
                    PropertyView propertyView = new PropertyView();
                    propertyView.ShowDialog();
                    break;

                case "Dispositivo electronico":
                    ElectronicView electronicView = new ElectronicView();
                    electronicView.ShowDialog();
                    break;

                case "Indumentaria":
                    IndumentaryView indumentaryView = new IndumentaryView();
                    indumentaryView.ShowDialog();
                    break;

            }

            }
            catch(Exception ex)
            {
                throw new Exception("Ingrese una opcion valida");
            }

        }

        public void UpdateBooking(int bookingId) 
        {
        
        }

        /*
        public BookingEntity GetBookingById(int bookingId)
        {

        }

        public List<BookingEntity> GetBookingEntities()
        {

        }
        */
        public void DeleteBooking(int bookingId)
        {
        
        }

    }
}
