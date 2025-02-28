using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Views.BookingsView.BookingsHistorialView;
using Boocking.Views.BookingsView.ToReserveView;
using Booking.Controllers;
using Booking.Controllers.EntitiesController;

namespace Boocking.Views.BookingsView
{
    public partial class BookingView : Form
    {

        private readonly BookingController bookingController = new BookingController();
        private readonly VehicleController vehicleController = new VehicleController();
        private readonly PropertyController propertyController = new PropertyController();
        private readonly IndumentaryController indumentaryController = new IndumentaryController();
        private readonly MainView mainView;
        private BookingsHistoricalView? bookingsHistoricalView;

        public BookingView(MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
        }

        private void btnToReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int entityToRentId = (int)dgvEntities.SelectedRows[0].Cells["rentableId"].Value;
                CreateBookingView creatingBooking = new CreateBookingView(entityToRentId);
                creatingBooking.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seleccione un articulo a alquilar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un articulo a alquilar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        #region Vehicle Methods

        private void CreateVehicleDataGridColumns()
        {
            dgvEntities.Columns.Add("rentableid", "Id");
            dgvEntities.Columns.Add("Name", "Nombre");
            dgvEntities.Columns.Add("Brand", "Marca");
            dgvEntities.Columns.Add("Model", "Modelo");
            dgvEntities.Columns.Add("Description", "Descripción");
            dgvEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvEntities.Columns.Add("PassengerCapacity", "Capacidad de Pasajeros");
            dgvEntities.Columns.Add("SerialNumber", "Número de Serie");
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {

                ClearDataGrid();
                CreateVehicleDataGridColumns();
                List<VehicleEntity> vehicles = vehicleController.GetAllVehicles();
                foreach (VehicleEntity vehicle in vehicles)
                {
                    dgvEntities.Rows.Add(
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

        #region Propeties Methods

        private void btnProperties_Click(object sender, EventArgs e)
        {
            try
            {
                ClearDataGrid();
                CreatePropertiesDataGridColumns();
                List<PropertyEntity> properties = propertyController.GetAllProperties();
                foreach (PropertyEntity property in properties)
                {
                    dgvEntities.Rows.Add(
                        property.RENTABLEID,
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

        private void CreatePropertiesDataGridColumns()
        {
            dgvEntities.Columns.Add("rentableId", "Id");
            dgvEntities.Columns.Add("Name", "Propiedad");
            dgvEntities.Columns.Add("Description", "Descripción");
            dgvEntities.Columns.Add("Location", "Ubicacion");
            dgvEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
        }

        #endregion

        #region Utility Methods

        private void ClearDataGrid()
        {
            ClearRows();
            ClearColumns();
        }

        private void ClearRows()
        {
            dgvEntities.Rows.Clear();
        }

        private void ClearColumns()
        {
            dgvEntities.Columns.Clear();
        }

        #endregion

        private void btnIndumentaries_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            CreateIndumentaryDataGridColumns();
            List<IndumentaryEntity> indumentaries = indumentaryController.GetAllIndumentaries();
            foreach(IndumentaryEntity indumentary in indumentaries)
            {
                dgvEntities.Rows.Add(
                    indumentary.RENTABLEID,
                    indumentary.NAME,
                    indumentary.DESCRIPTION,
                    indumentary.COSTUSAGEPERDAY,
                    indumentary.SIZE,
                    indumentary.GENRE
                    );
            }
        }

        private void CreateIndumentaryDataGridColumns()
        {
            dgvEntities.Columns.Add("rentableId", "Id");
            dgvEntities.Columns.Add("Name", "Indumentaria");
            dgvEntities.Columns.Add("Description", "Descripción");
            dgvEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvEntities.Columns.Add("Size", "Talle");
            dgvEntities.Columns.Add("Genre", "Genero");
        }

    }
}
