﻿using Boocking.Models.Entities;
using Booking.Controllers;
using Booking.Models.Strategy.Interface;

namespace Boocking.Views.BookingsView.ToReserveView
{
    public partial class CreateBookingView : Form
    {

        private readonly int rentableId;
        private readonly BookingController bookingController = new BookingController();
        private readonly PaymentStrategyController paymentStrategyController = new PaymentStrategyController();
        private readonly ClientController clientController = new ClientController();

        public CreateBookingView(int rentableId)
        {
            InitializeComponent();
            this.rentableId = rentableId;
            GetClients();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime initBooking = dtpInitReseservation.Value;
                DateTime endBooking = dtpEndReservation.Value;
                string paymentMethod = cbPaymentMethod.Text;
                IStrategyFinalPriceBooking paymentSelected = paymentStrategyController.GetPaymentData(paymentMethod);
                ClientEntity clientSelected = (ClientEntity)cbClients.SelectedItem;
                bool isChecked = checkBoxIsPayed.Checked;
                bool isAvailable = bookingController.CheckEntityAvailability(rentableId, initBooking, endBooking);
                if (!isAvailable)
                {
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

        private void GetClients()
        {
            try
            {
                List<ClientEntity> clients = new List<ClientEntity>();
                clients = clientController.GetClients();
                LoadClientsInCombobox(clients);
            }
            catch
            {

            }
        }

        private void LoadClientsInCombobox(List<ClientEntity> clients)
        {
            try
            {
                cbClients.DataSource = clients;
            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        



    }
}
