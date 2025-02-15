using Boocking.Models.Factory.Interfaces;

namespace Boocking.Views.RentableObjectsView
{
    public partial class VehicleView : Form
    {

        private readonly IVehicleFactory vehicleFactory;

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
                string passengerCapacity = numPassengerCapacity.GetType().ToString();

                vehicleFactory.CreateVehicleEntity(vehicleType, vehicleDescription, costUsage, vehicleBrand, vehicleModel, passengerCapacity, serialNumber);

            }
            catch
            {

            }

        }
    }
}
