using Boocking.Models.Entities.RentableEntities;
using Boocking.Views.BookingsView;
using Booking.Controllers.EntitiesController;
using Booking.Views.ItemsView.RentableObjectsView.ModifyView;

namespace Boocking.Views.RentableObjectsView
{
    public partial class PropertyView : Form
    {

        private readonly PropertyController propertyController = new PropertyController();
        private readonly RentablesView rentablesView;

        public PropertyView(RentablesView rentablesView)
        {
            InitializeComponent();
            this.rentablesView = rentablesView;
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
                MessageBox.Show("Propiedad creada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadProperties();
            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rentableId = (int)dgvProperties.SelectedRows[0].Cells["id"].Value;
            PropertyUpdateView propertyUpdateView = new PropertyUpdateView(rentableId);
            propertyUpdateView.ShowDialog();
            LoadProperties();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rentableId = (int)dgvProperties.SelectedRows[0].Cells["id"].Value;
            propertyController.DeleteProperty(rentableId);
            LoadProperties();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentablesView.Show();
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
            dgvProperties.Columns.Add("RentableId", "Id");
            dgvProperties.Columns.Add("Name", "Propiedad");
            dgvProperties.Columns.Add("Description", "Descripción");
            dgvProperties.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvProperties.Columns.Add("Location", "Ubicacion");
        }

    }
}
