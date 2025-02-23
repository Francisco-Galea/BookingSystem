using Boocking.Views.RentableObjectsView;

namespace Boocking.Views.BookingsView
{
    public partial class RentablesView : Form
    {

        public RentablesView()
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
            PropertyView propertyView = new PropertyView();
            propertyView.Show();
            this.Hide();
        }

        private void btnShowElectronics_Click(object sender, EventArgs e)
        {

        }

    }
}
