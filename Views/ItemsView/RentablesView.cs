using Boocking.Views.RentableObjectsView;

namespace Boocking.Views.BookingsView
{
    public partial class RentablesView : Form
    {

        private MainView mainView;

        public RentablesView(MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainView.Show();
        }
    }
}
