using Booking.Controllers;
using Booking.Models.Strategy.Interface;

namespace Boocking.Views.BookingsView.ToReserveView
{
    public partial class CreateBookingView : Form
    {

        private readonly int entityToRentId;
        private readonly BookingController bookingController = new BookingController();
        private readonly PaymentStrategyController paymentStrategyController = new PaymentStrategyController();

        public CreateBookingView(int entityId)
        {
            InitializeComponent();
            this.entityToRentId = entityId;
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime initBooking = dtpInitReseservation.Value;
                DateTime endBooking = dtpEndReservation.Value;
                string paymentMethod = cbPaymentMethod.Text;
                IStrategyFinalPriceBooking paymentSelected = paymentStrategyController.GetPaymentData(paymentMethod);
                bool isChecked = checkBoxIsPayed.Checked;
                bookingController.CreateBooking(entityToRentId, initBooking, endBooking, paymentSelected, isChecked);
                this.Close();
            }
            catch
            {

            }
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        



    }
}
