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
                bool isAvailable = bookingController.CheckEntityAvailability(entityToRentId, initBooking, endBooking);
                if (!isAvailable)
                {
                    MessageBox.Show("La entidad no está disponible en las fechas solicitadas.");
                    return;
                }
                bookingController.CreateBooking(entityToRentId, initBooking, endBooking, paymentSelected, isChecked);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        



    }
}
