using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities;
using Boocking.Models.Entities.RentableEntities;
using Booking.Controllers;
using Booking.Controllers.EntitiesController;
using Booking.Dtos.CoreDataBooking;
using Booking.Models.Strategy.Interface;

namespace Booking.Views.BookingsView.UpdateBookingView
{
    public partial class UpdateBookingView : Form
    {

        private readonly int bookingEntityId;
        private readonly BookingController bookingController = new BookingController();
        private readonly VehicleController vehicleController = new VehicleController();
        private readonly PaymentStrategyController paymentStrategyController = PaymentStrategyController.GetInstance();
        private readonly ClientController clientController = new ClientController();
        private readonly IndumentaryController indumentaryController = new IndumentaryController();
        private readonly PropertyController propertyController = new PropertyController();
        private readonly ElectronicController electronicController = new ElectronicController();

        public UpdateBookingView(int bookingId)
        {
            InitializeComponent();
            this.bookingEntityId = bookingId;
            GetOldBookingData(bookingEntityId);
            GetClients();
            LoadPaymentMethodsInComboBox(paymentStrategyController.GetPaymentMethods());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedEntityId = (int)dgvEntities.SelectedRows[0].Cells["rentableId"].Value;

                DateTime initBooking = dtpNewInitBooking.Value;
                DateTime endBooking = dtpNewEndBooking.Value;
                string paymentMethod = cbNewPaymentMethod.Text;
                IStrategyFinalPriceBooking paymentSelected = (IStrategyFinalPriceBooking)cbNewPaymentMethod.SelectedItem;
                ClientEntity clientSelected = (ClientEntity)cbNewClient.SelectedItem;
                bool isPaid = checkBoxNewIsPaid.Checked;
                bool isAvailable = bookingController.CheckAvailabilityForExistingBooking(selectedEntityId, bookingEntityId, initBooking, endBooking);
                if (!isAvailable)
                {
                    MessageBox.Show("La entidad no está disponible en las fechas solicitadas.");
                    return;
                }
                bookingController.UpdateBooking(bookingEntityId, selectedEntityId, initBooking, endBooking, clientSelected, paymentSelected, isPaid);
                this.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seleccione un articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Clients Methods

        private void GetClients()
        {
            List<ClientEntity> clients = new List<ClientEntity>();
            clients = clientController.GetClients();
            LoadClients(clients);
        }

        public void LoadClients(List<ClientEntity> clients)
        {
            cbNewClient.DataSource = clients;
        }

        #endregion

        #region Utility Methods

        private void LoadPaymentMethodsInComboBox(List<IStrategyFinalPriceBooking> paymentMethods)
        {
            cbNewPaymentMethod.DataSource = paymentMethods;
        }

        private void ClearDataGrid()
        {
            ClearColumns();
            ClearRows();
        }

        private void ClearColumns()
        {
            dgvEntities.Columns.Clear();
        }

        private void ClearRows()
        {
            dgvEntities.Rows.Clear();
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            dgvEntities.ClearSelection();
        }

        #endregion

        #region BookingMethods

        private void GetOldBookingData(int bookingEntityId)
        {
            BookingCoreDataDto bookingData = new BookingCoreDataDto();
            bookingData = bookingController.GetBookingCoreData(bookingEntityId);
            LoadOldBookingData(bookingData);
        }

        private void LoadOldBookingData(BookingCoreDataDto bookingData)
        {
            dtpInitBooking.Value = bookingData.initBooking;
            dtpEndBooking.Value = bookingData.endBooking;
            txtOldPaymentMethod.Text = bookingData.paymentMethod;
            checkBoxOldIsPaid.Checked = bookingData.isPaid;
            txtOldClient.Text = bookingData.oClient.ToString();
        }

        #endregion

        #region Property Methods

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            CreatePropertiesDataGridColumns();
            List<PropertyEntity> properties = propertyController.GetAllProperties();
            LoadProperties(properties);
        }

        private void LoadProperties(List<PropertyEntity> properties)
        {
            foreach (PropertyEntity property in properties)
            {
                dgvEntities.Rows.Add
                    (
                        property.RENTABLEID,
                        property.NAME,
                        property.DESCRIPTION,
                        property.COSTUSAGEPERDAY,
                        property.LOCATION
                    );
            }
        }

        private void CreatePropertiesDataGridColumns()
        {
            dgvEntities.Columns.Add("rentableId", "Id");
            dgvEntities.Columns.Add("propertyType", "Tipo de propiedad");
            dgvEntities.Columns.Add("description", "Descripcion");
            dgvEntities.Columns.Add("costUsage", "Tarifa diaria");
            dgvEntities.Columns.Add("location", "Ubicacion");
        }

        #endregion

        #region Indumentary Methods

        private void btnIndumentaries_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            CreateIndumentariesDataGridColumns();
            List<IndumentaryEntity> indumentaries = indumentaryController.GetAllIndumentaries();
            LoadIndumentariesData(indumentaries);
        }

        private void CreateIndumentariesDataGridColumns()
        {
            dgvEntities.Columns.Add("rentableId", "Id");
            dgvEntities.Columns.Add("Name", "Indumentaria");
            dgvEntities.Columns.Add("Description", "Descripción");
            dgvEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvEntities.Columns.Add("Size", "Talle");
            dgvEntities.Columns.Add("Genre", "Genero");
        }

        private void LoadIndumentariesData(List<IndumentaryEntity> indumentaries)
        {
            foreach (IndumentaryEntity indumentary in indumentaries)
            {
                dgvEntities.Rows.Add
                    (
                    indumentary.RENTABLEID,
                    indumentary.NAME,
                    indumentary.DESCRIPTION,
                    indumentary.COSTUSAGEPERDAY,
                    indumentary.SIZE,
                    indumentary.GENRE
                    );
            }
        }

        #endregion

        #region Electronic Methods

        private void btnElectronics_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            CreateElectronicsDataGridColumns();
            List<ElectronicEntity> electronics = electronicController.GetAllElectronics();
            LoadElectronics(electronics);
        }

        private void LoadElectronics(List<ElectronicEntity> electronics)
        {
            foreach (ElectronicEntity electronic in electronics)
            {
                dgvEntities.Rows.Add
                    (
                        electronic.RENTABLEID,
                        electronic.NAME,
                        electronic.DESCRIPTION,
                        electronic.COSTUSAGEPERDAY,
                        electronic.BRAND,
                        electronic.MODEL,
                        electronic.SERIALNUMBER
                    );
            }
        }

        private void CreateElectronicsDataGridColumns()
        {
            dgvEntities.Columns.Add("rentableId", "Id");
            dgvEntities.Columns.Add("Name", "Dispositivo");
            dgvEntities.Columns.Add("Description", "Descripcion");
            dgvEntities.Columns.Add("CostUsage", "Tarifa diaria");
            dgvEntities.Columns.Add("Brand", "Marca");
            dgvEntities.Columns.Add("Model", "Modelo");
            dgvEntities.Columns.Add("SerialNumber", "Número de serie");
        }

        #endregion

        #region Vehicle Methods

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            CreateVehicleDataGridColumns();
            List<VehicleEntity> vehicles = vehicleController.GetAllVehicles();
            LoadVehiclesData(vehicles);
        }

        private void CreateVehicleDataGridColumns()
        {
            dgvEntities.Columns.Add("rentableId", "Id");
            dgvEntities.Columns.Add("Name", "Nombre");
            dgvEntities.Columns.Add("Brand", "Marca");
            dgvEntities.Columns.Add("Model", "Modelo");
            dgvEntities.Columns.Add("Description", "Descripción");
            dgvEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvEntities.Columns.Add("PassengerCapacity", "Capacidad de Pasajeros");
            dgvEntities.Columns.Add("SerialNumber", "Número de Serie");
        }

        private void LoadVehiclesData(List<VehicleEntity> vehicles)
        {
            foreach (VehicleEntity vehicle in vehicles)
            {
                dgvEntities.Rows.Add
                    (
                        vehicle.RENTABLEID,
                        vehicle.NAME,
                        vehicle.BRAND,
                        vehicle.MODEL,
                        vehicle.DESCRIPTION,
                        vehicle.COSTUSAGEPERDAY,
                        vehicle.PASSENGERCAPACITY,
                        vehicle.SERIALNUMBER
                    );
            }
        }

        #endregion

    }
}
