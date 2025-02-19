using Boocking.Controllers;
using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Booking.Controllers;

namespace Boocking.Views.BookingsView
{
    public partial class ItemsView : Form
    {
        private readonly BookingController bookingController = new BookingController();
        private readonly RentableEntityController rentableEntityController = new RentableEntityController();
        private readonly VehicleController vehicleController = new VehicleController();
        private string selectedEntityType;

        public ItemsView()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedEntity = cbbRentableEntities.SelectedItem as string;
                rentableEntityController.CreateSelectedEntity(selectedEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnShowIndumentary_Click(object sender, EventArgs e)
        {

        }

        private void btnShowVehicles_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            dataGridViewEntities.Columns.Add("id", "Id");
            dataGridViewEntities.Columns.Add("Name", "Nombre");
            dataGridViewEntities.Columns.Add("Description", "Descripción");
            dataGridViewEntities.Columns.Add("CostUsagePerDay", "Costo por Día");
            dataGridViewEntities.Columns.Add("Brand", "Marca");
            dataGridViewEntities.Columns.Add("Model", "Modelo");
            dataGridViewEntities.Columns.Add("SerialNumber", "Número de Serie");
            dataGridViewEntities.Columns.Add("PassengerCapacity", "Capacidad de Pasajeros");
            LoadVehiclesData();
        }

        private void btnShowProperties_Click(object sender, EventArgs e)
        {

        }

        private void btnShowElectronics_Click(object sender, EventArgs e)
        {

        }

        private void ClearDataGrid()
        {
            dataGridViewEntities.Rows.Clear();
            dataGridViewEntities.Columns.Clear();
        }

        private void LoadVehiclesData()
        {
            try
            {

                selectedEntityType = "Vehicle";
                List<VehicleEntity> vehicles = vehicleController.GetAllVehicles();
                foreach (VehicleEntity vehicle in vehicles)
                {
                    dataGridViewEntities.Rows.Add(
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int entityId = (int)dataGridViewEntities.SelectedRows[0].Cells["id"].Value;
            rentableEntityController.DeleteSelectedEntity(entityId, selectedEntityType);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int entityId = (int)dataGridViewEntities.SelectedRows[0].Cells["id"].Value;
            rentableEntityController.UpdateSelectedEntity(entityId, selectedEntityType);
        }
    }
}
