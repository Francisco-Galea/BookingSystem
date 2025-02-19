
using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Booking.Controllers.EntitiesController;
using Booking.Views.ItemsView.RentableObjectsView.ModifyView;

namespace Boocking.Views.RentableObjectsView
{
    public partial class PropertyView : Form
    {

        private readonly PropertyController propertyController = new PropertyController();

        public PropertyView()
        {
            InitializeComponent();
            CreateDataGridColumns();
            LoadProperties();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string propertyType = txtProperty.Text;
                string description = txtDescription.Text;
                string costUsage = txtCostUsage.Text;
                string location = txtLocation.Text;
                propertyController.CreateProperty(propertyType, description, costUsage, location);
                LoadProperties();
            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int entityId = (int)dgvProperties.SelectedRows[0].Cells["id"].Value;
            PropertyUpdateView propertyUpdateView = new PropertyUpdateView(entityId);
            propertyUpdateView.ShowDialog();
            LoadProperties();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadProperties();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void LoadProperties()
        {
            try
            {
                ClearRows();
                List<PropertyEntity> properties = propertyController.GetAllProperties();
                foreach (PropertyEntity property in properties)
                {
                    dgvProperties.Rows.Add(
                        property.PROPERTYID,
                        property.NAME,
                        property.DESCRIPTION,
                        property.LOCATION,
                        property.COSTUSAGEPERDAY
                        );
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ClearRows()
        {
            dgvProperties.Rows.Clear();
        }

        private void CreateDataGridColumns()
        {
            dgvProperties.Columns.Add("id", "Id");
            dgvProperties.Columns.Add("Name", "Propiedad");
            dgvProperties.Columns.Add("Description", "Descripción");
            dgvProperties.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvProperties.Columns.Add("Location", "Ubicacion");
        }

    }
}
