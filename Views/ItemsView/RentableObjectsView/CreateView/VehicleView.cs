using Boocking.Controllers.EntitiesController;

namespace Boocking.Views.RentableObjectsView
{
    public partial class VehicleView : Form
    {

        private readonly VehicleController vehicleController = new VehicleController();

        public VehicleView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.Close();
            }
            catch
            {
                throw;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

    }
}
