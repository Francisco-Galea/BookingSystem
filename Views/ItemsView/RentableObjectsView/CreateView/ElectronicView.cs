using Boocking.Views.BookingsView;

namespace Boocking.Views.RentableObjectsView
{
    public partial class ElectronicView : Form
    {

        private readonly RentablesView rentablesView;

        public ElectronicView(RentablesView rentablesView)
        {
            InitializeComponent();
            this.rentablesView = rentablesView;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentablesView.Show();
        }
    }
}
