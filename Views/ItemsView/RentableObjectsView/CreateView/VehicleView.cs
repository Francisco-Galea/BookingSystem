using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Booking.Views.ItemsView.RentableObjectsView.ModifyView;

namespace Boocking.Views.RentableObjectsView
{
    public partial class VehicleView : Form
    {

        private readonly VehicleController vehicleController = new VehicleController();

        public VehicleView()
        {
            InitializeComponent();
            CreateDataGridColumns();
            LoadVehicles();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicleType = txtVehicleName.Text;
                string vehicleBrand = txtBrand.Text;
                string vehicleModel = txtModel.Text;
                string vehicleDescription = txtDescription.Text;
                string costUsage = txtCostUsage.Text;
                string serialNumber = txtSerialNumber.Text;
                string passengerCapacity = txtPassengerCapacity.Text;
                vehicleController.CreateVehicle(vehicleType, vehicleDescription, costUsage, vehicleBrand, vehicleModel, passengerCapacity, serialNumber);
                LoadVehicles();
                CleanTextBox();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rentableId = (int)dgvVehicles.SelectedRows[0].Cells["Rentableid"].Value;
            vehicleController.DeleteVehicle(rentableId);
            LoadVehicles();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int rentableId = (int)dgvVehicles.SelectedRows[0].Cells["Rentableid"].Value;
            VehicleUpdateView vehicleUpdateView = new VehicleUpdateView(rentableId);
            vehicleUpdateView.ShowDialog();
            LoadVehicles();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void ClearRows()
        {
            dgvVehicles.Rows.Clear();
        }

        private void LoadVehicles()
        {
            try
            {
                ClearRows();
                List<VehicleEntity> vehicles = vehicleController.GetAllVehicles();
                foreach (VehicleEntity vehicle in vehicles)
                {
                    dgvVehicles.Rows.Add(
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

        private void CleanTextBox()
        {
            txtVehicleName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCostUsage.Text = string.Empty;
            txtBrand.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtSerialNumber.Text = string.Empty;
            txtPassengerCapacity.Text = string.Empty;
        }

        private void CreateDataGridColumns()
        {
            dgvVehicles.Columns.Add("Rentableid", "Id rentable");
            dgvVehicles.Columns.Add("Name", "Nombre");
            dgvVehicles.Columns.Add("Description", "Descripción");
            dgvVehicles.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvVehicles.Columns.Add("Brand", "Marca");
            dgvVehicles.Columns.Add("Model", "Modelo");
            dgvVehicles.Columns.Add("SerialNumber", "Número de Serie");
            dgvVehicles.Columns.Add("PassengerCapacity", "Capacidad de Pasajeros");
        }

    }
}
