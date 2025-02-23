

using Booking.Controllers;
using Booking.Dtos.CoreDataBooking;

namespace Booking.Views.BookingsView.UpdateBookingView
{
    public partial class UpdateBookingView : Form
    {

        private readonly int bookingEntityId;
        private readonly BookingController bookingController = new BookingController();

        public UpdateBookingView(int bookingId)
        {
            InitializeComponent();
            this.bookingEntityId = bookingId;
        }

        private void GetOldBookingData()
        {
            try
            {
                BookingCoreDataDto bookingData = new BookingCoreDataDto();
                bookingData = bookingController.GetBookingCoreData(bookingEntityId);
                LoadOldBookingData(bookingData);
            }
            catch
            {

            }
        }

        private void LoadOldBookingData(BookingCoreDataDto bookingData) 
        {
            try
            {

            }
            catch
            {

            }
        }


    }
}
