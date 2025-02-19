using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Booking.Controllers.EntitiesController;

namespace Booking.Views.ItemsView.RentableObjectsView.ModifyView
{
    public partial class PropertyUpdateView : Form
    {

        private readonly PropertyController propertyController = new PropertyController();
        private readonly int propertyId;

        public PropertyUpdateView(int entityId)
        {
            InitializeComponent();
            LoadOldPropertyData(entityId);
            propertyId = entityId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string propertyType = txtNewPropertyType.Text;
            string description = txtNewDescription.Text;
            string costUsage = txtNewCostUsage.Text;
            string location = txtNewLocation.Text;
            propertyController.UpdateProperty(propertyId, propertyType, description, costUsage, location);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void LoadOldPropertyData(int entityId)
        {
            try
            {
                PropertyEntity oldPropertyData = new PropertyEntity();
                oldPropertyData = propertyController.GetPropertyById(entityId);
                txtOldProperty.Text = oldPropertyData.NAME;
                txtOldDescription.Text = oldPropertyData.DESCRIPTION;
                txtOldCostUsage.Text = oldPropertyData.COSTUSAGEPERDAY.ToString();
                txtOldLocation.Text = oldPropertyData.LOCATION;
            }
            catch { }
        }

    }
}
