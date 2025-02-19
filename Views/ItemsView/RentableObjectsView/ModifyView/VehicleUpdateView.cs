using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;

namespace Booking.Views.ItemsView.RentableObjectsView.ModifyView
{
    public partial class VehicleUpdateView : Form
    {
        
        private readonly VehicleController vehicleController = new VehicleController();
        private readonly int vehicleId;

        public VehicleUpdateView(int entityId)
        {
            InitializeComponent();
            LoadOldVehicleData(entityId);
            vehicleId = entityId;
        }

        private void LoadOldVehicleData(int entityId)
        {
            try
            {
                VehicleEntity oldVehicleData = new VehicleEntity();
                oldVehicleData = vehicleController.GetVehicleById(entityId);
                txtOldVehicle.Text = oldVehicleData.NAME;
                txtOldBrand.Text = oldVehicleData.BRAND;
                txtOldModel.Text = oldVehicleData.MODEL;
                txtOldDescription.Text = oldVehicleData.DESCRIPTION;
                txtOldCost.Text = oldVehicleData.COSTUSAGEPERDAY.ToString();
                txtOldSerialNumber.Text = oldVehicleData.SERIALNUMBER;
                txtOldPassenger.Text = oldVehicleData.PASSENGERCAPACITY.ToString();
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicleType = txtNewVehicle.Text;
                string vehicleBrand = txtNewBrand.Text;
                string vehicleModel = txtNewModel.Text;
                string vehicleDescription = txtNewDescription.Text;
                string costUsage = txtNewCost.Text;
                string serialNumber = txtNewSerialNumber.Text;
                string passengerCapacity = txtNewPassenger.Text;
                vehicleController.UpdateVehicle(vehicleId, vehicleType, vehicleDescription, costUsage, vehicleBrand, vehicleModel, passengerCapacity, serialNumber);
            }
            catch
            {

            }
        }
    }
}
