using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Views.BookingsView;
using Booking.Views.ItemsView.RentableObjectsView.ModifyView;

namespace Boocking.Views.RentableObjectsView
{
    public partial class VehicleView : Form
    {

        private readonly VehicleController vehicleController = new VehicleController();
        private readonly RentablesView rentablesView;

        public VehicleView(RentablesView rentablesView)
        {
            InitializeComponent();
            this.rentablesView = rentablesView;
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
            try
            {

                int rentableId = (int)dgvVehicles.SelectedRows[0].Cells["Rentableid"].Value;
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este vehiculo?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                vehicleController.DeleteVehicle(rentableId, result);
                LoadVehicles();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un vehiculo a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int rentableId = (int)dgvVehicles.SelectedRows[0].Cells["Rentableid"].Value;
                VehicleUpdateView vehicleUpdateView = new VehicleUpdateView(rentableId);
                vehicleUpdateView.ShowDialog();
                LoadVehicles();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un vehiculo a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentablesView.Show();
        }

        
        private void LoadVehicles()
        {
            ClearRows();
            List<VehicleEntity> vehicles = vehicleController.GetAllVehicles();
            foreach (VehicleEntity vehicle in vehicles)
            {
                dgvVehicles.Rows.Add
                    (
                    vehicle.NAME,
                    vehicle.BRAND,
                    vehicle.MODEL,
                    vehicle.PASSENGERCAPACITY,
                    vehicle.COSTUSAGEPERDAY,
                    vehicle.DESCRIPTION,
                    vehicle.SERIALNUMBER,
                    vehicle.VEHICLEID
                    );
            }
        }

        #region Utility Methods
        private void CreateDataGridColumns()
        {
            dgvVehicles.Columns.Add("Name", "Nombre");
            dgvVehicles.Columns.Add("Brand", "Marca");
            dgvVehicles.Columns.Add("Model", "Modelo");
            dgvVehicles.Columns.Add("PassengerCapacity", "Capacidad de Pasajeros");
            dgvVehicles.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvVehicles.Columns.Add("Description", "Descripción");
            dgvVehicles.Columns.Add("SerialNumber", "Número de Serie");
            dgvVehicles.Columns.Add("Rentableid", "Id rentable");
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

        private void ClearRows()
        {
            dgvVehicles.Rows.Clear();
        }



        #endregion

    }
}
