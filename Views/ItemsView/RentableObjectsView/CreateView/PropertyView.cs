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
                ClearTextBox();
                LoadProperties();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rentableId = (int)dgvProperties.SelectedRows[0].Cells["Rentableid"].Value;
                PropertyUpdateView propertyUpdateView = new PropertyUpdateView(rentableId);
                propertyUpdateView.ShowDialog();
                LoadProperties();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una propiedad a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int rentableId = (int)dgvProperties.SelectedRows[0].Cells["Rentableid"].Value;
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este vehiculo?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                propertyController.DeleteProperty(rentableId, result);
                LoadProperties();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una propiedad a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentablesView.Show();
        }

        private void LoadProperties()
        {
            ClearRows();
            List<PropertyEntity> properties = propertyController.GetAllProperties();
            foreach (PropertyEntity property in properties)
            {
                dgvProperties.Rows.Add
                    (
                    property.NAME,
                    property.DESCRIPTION,
                    property.LOCATION,
                    property.COSTUSAGEPERDAY,
                    property.PROPERTYID
                    );
            }
        }

        #region Utility Methods

        private void CreateDataGridColumns()
        {
            dgvProperties.Columns.Add("Name", "Propiedad");
            dgvProperties.Columns.Add("Description", "Descripción");
            dgvProperties.Columns.Add("Location", "Ubicacion");
            dgvProperties.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvProperties.Columns.Add("RentableId", "Id");
        }

        private void ClearRows()
        {
            dgvProperties.Rows.Clear();
        }

        private void ClearTextBox()
        {
            txtProperty.Clear();
            txtDescription.Clear();
            txtCostUsage.Clear();
            txtLocation.Clear();
        }

        #endregion

    }
}
