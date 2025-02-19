
using Booking.Controllers.EntitiesController;

namespace Boocking.Views.RentableObjectsView
{
    public partial class PropertyView : Form
    {
        private readonly PropertyController propertyController;

        public PropertyView()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string propertyType = txtProperty.Text;
                string description = txtDescription.Text;
                string costUsage = txtCostUsage.Text;
                string direction = txtDirection.Text;
                propertyController.CreateProperty(propertyType, description, costUsage, direction);
            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
