using Booking.Controllers;

namespace Boocking.Views.BookingsView.ToReserveView
{
    public partial class CreateBookingView : Form
    {

        private readonly int entityToRentId;
        private readonly BookingController bookingController = new BookingController();

        public CreateBookingView(int entityId)
        {
            InitializeComponent();
            this.entityToRentId = entityId;
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            string initBooking = dtpInitReservation.Text;
            string endBooking = dtpEndReservation.Text;
            string paymentMethod = cbPaymentMethod.Text;
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        



    }
}
