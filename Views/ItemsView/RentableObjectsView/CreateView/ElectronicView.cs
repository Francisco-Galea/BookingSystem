using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Views.BookingsView;
using Booking.Controllers.EntitiesController;
using Booking.Views.ItemsView.RentableObjectsView.ModifyView;

namespace Boocking.Views.RentableObjectsView
{
    public partial class ElectronicView : Form
    {

        private readonly RentablesView rentablesView;
        private readonly ElectronicController electronicController = new ElectronicController();

        public ElectronicView(RentablesView rentablesView)
        {
            InitializeComponent();
            this.rentablesView = rentablesView;
            CreateDataGridColumns();
            LoadElectronics();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string electronicType = txtName.Text;
                string description = txtDescription.Text;
                string costUsage = txtCostUsage.Text;
                string brand = txtBrand.Text;
                string model = txtModel.Text;
                string serialNumber = txtSerialNumber.Text;
                electronicController.CreateElectronic(electronicType, description, costUsage, brand, model, serialNumber);
                MessageBox.Show("Dispositivo electronico creado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadElectronics();
                CleanTextBox();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rentableId = (int)dgvElectronics.SelectedRows[0].Cells["Rentableid"].Value;
                ElectronicUpdateView electronicUpdateView = new ElectronicUpdateView(rentableId);
                electronicUpdateView.ShowDialog();
                LoadElectronics();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un vehiculo a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadElectronics()
        {
            ClearRows();
            List<ElectronicEntity> electronics = electronicController.GetAllElectronics();
            foreach (ElectronicEntity electronic in electronics)
            {
                dgvElectronics.Rows.Add
                    (
                    electronic.RENTABLEID,
                    electronic.NAME,
                    electronic.BRAND,
                    electronic.MODEL,
                    electronic.COSTUSAGEPERDAY,
                    electronic.DESCRIPTION,
                    electronic.SERIALNUMBER
                    );
            }
        }

        private void CreateDataGridColumns()
        {
            dgvElectronics.Columns.Add("rentableid", "Id");
            dgvElectronics.Columns.Add("Name", "Nombre");
            dgvElectronics.Columns.Add("Brand", "Marca");
            dgvElectronics.Columns.Add("Model", "Modelo");
            dgvElectronics.Columns.Add("CostUsagePerDay", "Costo por Día");
            dgvElectronics.Columns.Add("Description", "Descripción");
            dgvElectronics.Columns.Add("SerialNumber", "Número de Serie");
        }

        private void CleanTextBox()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCostUsage.Text = string.Empty;
            txtBrand.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtSerialNumber.Text = string.Empty;
        }

        private void ClearRows()
        {
            dgvElectronics.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int rentableId = (int)dgvElectronics.SelectedRows[0].Cells["rentableid"].Value;
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este dispositivo electronico?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                electronicController.DeleteElectronic(rentableId, result);
                MessageBox.Show("Dispositivo electronico borrado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadElectronics();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Seleccione un dispositivo electronico a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un dispositivo electronico a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
