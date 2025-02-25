using Boocking.Views.BookingsView;

namespace Boocking.Views.ItemsView.RentableObjectsView
{
    public partial class IndumentaryView : Form
    {

        private readonly RentablesView rentablesView;

        public IndumentaryView(RentablesView rentablesView)
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
