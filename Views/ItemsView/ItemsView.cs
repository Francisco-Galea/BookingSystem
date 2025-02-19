using Boocking.Views.RentableObjectsView;

namespace Boocking.Views.BookingsView
{
    public partial class ItemsView : Form
    {
        private readonly VehicleView vehicleView;

        public ItemsView()
        {
            InitializeComponent();
        }

        private void btnShowIndumentary_Click(object sender, EventArgs e)
        {

        }

        private void btnShowVehicles_Click(object sender, EventArgs e)
        {
            VehicleView vehicleView = new VehicleView();
            vehicleView.Show();
            this.Hide();
        }

        private void btnShowProperties_Click(object sender, EventArgs e)
        {

        }

        private void btnShowElectronics_Click(object sender, EventArgs e)
        {

        }

    }
}
