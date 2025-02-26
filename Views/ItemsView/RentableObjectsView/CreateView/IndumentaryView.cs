using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Views.BookingsView;
using Booking.Controllers.EntitiesController;
using Booking.Views.ItemsView.RentableObjectsView.ModifyView;

namespace Boocking.Views.ItemsView.RentableObjectsView
{
    public partial class IndumentaryView : Form
    {

        private readonly RentablesView rentablesView;
        private readonly IndumentaryController indumentaryController = new IndumentaryController();

        public IndumentaryView(RentablesView rentablesView)
        {
            InitializeComponent();
            this.rentablesView = rentablesView;
            this.rentablesView = rentablesView;
            CreateDataGridColumns();
            LoadIndumentaries();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string indumentaryType = txtIndimentaryType.Text;
                string description = txtDescription.Text;
                string costUsage = txtCostUsage.Text;
                string size = txtSize.Text;
                string genre = txtGenre.Text;
                indumentaryController.CreateIndumentary(indumentaryType, description, costUsage, size, genre);
                LoadIndumentaries();
                CleanTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanTextBox()
        {
            txtIndimentaryType.Clear();
            txtDescription.Clear();
            txtCostUsage.Clear();
            txtGenre.Clear();
            txtSize.Clear();
        }

        private void CreateDataGridColumns()
        {
            dgvIndumentary.Columns.Add("IndumentaryType", "Indumentaria");
            dgvIndumentary.Columns.Add("Description", "Descripccion");
            dgvIndumentary.Columns.Add("CostUsage", "Tarifa diaria");
            dgvIndumentary.Columns.Add("Size", "Talle");
            dgvIndumentary.Columns.Add("Genre", "Genero");
            dgvIndumentary.Columns.Add("RentableId", "Id rentable");
        }

        private void LoadIndumentaries()
        {
            ClearRows();
            List<IndumentaryEntity> indumentaries = indumentaryController.GetAllIndumentaries();
            foreach (IndumentaryEntity indumentary in indumentaries)
            {
                dgvIndumentary.Rows.Add(
                    indumentary.NAME,
                    indumentary.DESCRIPTION,
                    indumentary.COSTUSAGEPERDAY,
                    indumentary.SIZE,
                    indumentary.GENRE,
                    indumentary.RENTABLEID
                    );
            }
        }

        private void ClearRows()
        {
            dgvIndumentary.Rows.Clear();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentablesView.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int rentableId = (int)dgvIndumentary.SelectedRows[0].Cells["Rentableid"].Value;
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta indumentaria?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                indumentaryController.DeleteIndumentary(rentableId, result);
                LoadIndumentaries();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una indumentaria a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int rentableId = (int)dgvIndumentary.SelectedRows[0].Cells["Rentableid"].Value;
                IndumentaryUpdateView indumentaryUpdateView = new IndumentaryUpdateView(rentableId);
                indumentaryUpdateView.ShowDialog();
                LoadIndumentaries();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una indumentaria a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
