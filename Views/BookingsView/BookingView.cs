using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Views.BookingsView.BookingsHistorialView;
using Boocking.Views.BookingsView.ToReserveView;
using Booking.Controllers;
using Booking.Controllers.EntitiesController;
using Booking.Views.ClientsView;

namespace Boocking.Views.BookingsView
{
    public partial class BookingView : Form
    {

        private readonly BookingController bookingController = new BookingController();
        private readonly VehicleController vehicleController = new VehicleController();
        private readonly PropertyController propertyController = new PropertyController();
        private MainView mainView;
        private BookingsHistoricalView bookingsHistoricalView;

        public BookingView(MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
        }


        private void btnToReserve_Click(object sender, EventArgs e)
        {
            int entityId = (int)dgvEntities.SelectedRows[0].Cells["id"].Value;
            CreateBookingView creatingBooking = new CreateBookingView(entityId);
            creatingBooking.ShowDialog();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRows();
                ClearColumns();
                CreateVehicleDataGridColumns();
                List<VehicleEntity> vehicles = vehicleController.GetAllVehicles();
                foreach (VehicleEntity vehicle in vehicles)
                {
                    dgvEntities.Rows.Add(
                        vehicle.VEHICLEID,
                        vehicle.NAME,
                        vehicle.DESCRIPTION,
                        vehicle.COSTUSAGEPERDAY,
                        vehicle.BRAND,
                        vehicle.MODEL,
                        vehicle.SERIALNUMBER,
                        vehicle.PASSENGERCAPACITY
                        );
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRows();
                ClearColumns();
                CreatePropertiesDataGridColumns();
                List<PropertyEntity> properties = propertyController.GetAllProperties();
                foreach (PropertyEntity property in properties)
                {
                    dgvEntities.Rows.Add(
                        property.PROPERTYID,
                        property.NAME,
                        property.DESCRIPTION,
                        property.LOCATION,
                        property.COSTUSAGEPERDAY
                        );
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ClearRows()
        {
            dgvEntities.Rows.Clear();
        }

        private void ClearColumns()
        {
            dgvEntities.Columns.Clear();
        }

        private void CreateVehicleDataGridColumns()
        {
            dgvEntities.Columns.Add("id", "Id");
            dgvEntities.Columns.Add("Name", "Nombre");
            dgvEntities.Columns.Add("Description", "Descripción");
            dgvEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvEntities.Columns.Add("Brand", "Marca");
            dgvEntities.Columns.Add("Model", "Modelo");
            dgvEntities.Columns.Add("SerialNumber", "Número de Serie");
            dgvEntities.Columns.Add("PassengerCapacity", "Capacidad de Pasajeros");
        }

        private void CreatePropertiesDataGridColumns()
        {
            dgvEntities.Columns.Add("id", "Id");
            dgvEntities.Columns.Add("Name", "Propiedad");
            dgvEntities.Columns.Add("Description", "Descripción");
            dgvEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvEntities.Columns.Add("Location", "Ubicacion");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainView.Show();
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            if (bookingsHistoricalView == null || bookingsHistoricalView.IsDisposed)
            {
                bookingsHistoricalView = new BookingsHistoricalView(this); 
            }
            this.Hide();
            bookingsHistoricalView.Show();
        }
    }
}
