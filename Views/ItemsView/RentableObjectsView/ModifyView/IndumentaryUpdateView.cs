using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Models.Factory;
using Boocking.Models.Factory.Interfaces;
using Booking.Controllers.EntitiesController;

namespace Booking.Views.ItemsView.RentableObjectsView.ModifyView
{
    public partial class IndumentaryUpdateView : Form
    {

        private readonly IndumentaryController indumentaryController = new IndumentaryController();
        private readonly IIndumentaryFactory indumentaryFactory = new IndumentaryFactory();
        private readonly int rentableIndumentaryId;

        public IndumentaryUpdateView(int rentableIndumentaryId)
        {
            InitializeComponent();
            this.rentableIndumentaryId = rentableIndumentaryId;
            LoadOldIndumentary(rentableIndumentaryId);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string indumentaryType = txtNewIndumentaryType.Text;
                string description = txtNewDescription.Text;
                string costUsage = txtNewCostUsage.Text;
                string size = txtNewSize.Text;
                string genre = txtNewGenre.Text;
                indumentaryController.UpdateIndumentary(rentableIndumentaryId, indumentaryType, description, costUsage, size, genre);
                MessageBox.Show("Indumentaria actualizada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadOldIndumentary(int rentableIndumentaryId)
        {
            IndumentaryEntity indumentary = indumentaryFactory.CreateIndumentaryEntity();
            indumentary = indumentaryController.GetIndumentaryById(rentableIndumentaryId);
            txtOldIndumentaryType.Text = indumentary.NAME;
            txtOldDescription.Text = indumentary.DESCRIPTION;
            txtOldCostUsage.Text = indumentary.COSTUSAGEPERDAY.ToString();
            txtOldSize.Text = indumentary.SIZE;
            txtOldGenre.Text = indumentary.GENRE;
        }

    }
}
