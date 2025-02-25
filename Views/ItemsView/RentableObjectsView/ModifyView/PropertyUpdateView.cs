using Boocking.Models.Entities.RentableEntities;
using Booking.Controllers.EntitiesController;

namespace Booking.Views.ItemsView.RentableObjectsView.ModifyView
{
    public partial class PropertyUpdateView : Form
    {

        private readonly PropertyController propertyController = new PropertyController();
        private readonly int rentablePropertyId;

        public PropertyUpdateView(int rentableId)
        {
            InitializeComponent();
            LoadOldPropertyData(rentableId);
            this.rentablePropertyId = rentableId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string propertyType = txtNewPropertyType.Text;
                string description = txtNewDescription.Text;
                string costUsage = txtNewCostUsage.Text;
                string location = txtNewLocation.Text;
                propertyController.UpdateProperty(rentablePropertyId, propertyType, description, costUsage, location);
                this.Close();
            }
            catch
            {

            }
        }

        private void LoadOldPropertyData(int rentableId)
        {
            try
            {
                PropertyEntity oldPropertyData = new PropertyEntity();
                oldPropertyData = propertyController.GetPropertyById(rentableId);
                txtOldProperty.Text = oldPropertyData.NAME;
                txtOldDescription.Text = oldPropertyData.DESCRIPTION;
                txtOldCostUsage.Text = oldPropertyData.COSTUSAGEPERDAY.ToString();
                txtOldLocation.Text = oldPropertyData.LOCATION;
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
