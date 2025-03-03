using Boocking.Models.Entities;
using Booking.Controllers;
using Booking.Models.Strategy;
using Booking.Models.Strategy.Interface;

namespace Boocking.Views.BookingsView.ToReserveView
{
    public partial class CreateBookingView : Form
    {

        private readonly int rentableId;
        private readonly BookingController bookingController = new BookingController();
        private readonly PaymentStrategyController paymentStrategyController = PaymentStrategyController.GetInstance();
        private readonly ClientController clientController = new ClientController();
        private readonly List<IStrategyFinalPriceBooking> paymentMethods = new List<IStrategyFinalPriceBooking>();

        public CreateBookingView(int rentableId)
        {
            InitializeComponent();
            this.rentableId = rentableId;
            GetClients();           
            LoadPaymentMethodsInComboBox(paymentStrategyController.GetPaymentMethods());
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime initBooking = dtpInitReseservation.Value;
                DateTime endBooking = dtpEndReservation.Value;
                string paymentMethod = cbPaymentMethod.Text;
                IStrategyFinalPriceBooking paymentSelected = (IStrategyFinalPriceBooking)cbPaymentMethod.SelectedItem;
                ClientEntity clientSelected = (ClientEntity)cbClients.SelectedItem;
                bool isChecked = checkBoxIsPayed.Checked;
                bool isAvailable = bookingController.CheckEntityAvailability(rentableId, initBooking, endBooking);
                if (!isAvailable)
                {;
                    MessageBox.Show("La entidad no está disponible en las fechas solicitadas.");
                    return;
                }
                bookingController.CreateBooking(rentableId, initBooking, endBooking, clientSelected, paymentSelected, isChecked);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaymentMethodsInComboBox(List<IStrategyFinalPriceBooking> paymentMethods)
        {
            cbPaymentMethod.DataSource = paymentMethods;
        }

        private void GetClients()
        {
            List<ClientEntity> clients = new List<ClientEntity>();
            clients = clientController.GetClients();
            LoadClientsInCombobox(clients);
        }

        private void LoadClientsInCombobox(List<ClientEntity> clients)
        {
            cbClients.DataSource = clients;          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Tarjeta de Crédito
        //Transferencia
        //Efectivo



    }
}
