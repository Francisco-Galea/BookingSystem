using Boocking.Views.ItemsView.RentableObjectsView;
using Boocking.Views.RentableObjectsView;

namespace Boocking.Views.BookingsView
{
    public partial class RentablesView : Form
    {

        private MainView mainView;
        private VehicleView vehicleView;
        private PropertyView propertyView;
        private IndumentaryView indumentaryView;
        private ElectronicView electronicView;

        public RentablesView(MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
        }

        private void btnShowIndumentary_Click(object sender, EventArgs e)
        {
            if (indumentaryView == null || indumentaryView.IsDisposed)
            {
                indumentaryView = new IndumentaryView(this);
            }
            this.Hide();
            indumentaryView.Show();
        }

        private void btnShowVehicles_Click(object sender, EventArgs e)
        {
            if (vehicleView == null || vehicleView.IsDisposed)
            {
                vehicleView = new VehicleView(this);  
            }
            this.Hide();
            vehicleView.Show();
        }

        private void btnShowProperties_Click(object sender, EventArgs e)
        {
            if (propertyView == null || propertyView.IsDisposed)
            {
                propertyView = new PropertyView(this); 
            }
            this.Hide();
            propertyView.Show();
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
