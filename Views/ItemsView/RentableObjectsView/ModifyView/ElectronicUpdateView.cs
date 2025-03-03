using Boocking.Models.Entities.RentableEntities;
using Booking.Controllers.EntitiesController;
using Booking.Models.Factory;
using Booking.Models.Factory.Interface;

namespace Booking.Views.ItemsView.RentableObjectsView.ModifyView
{
    public partial class ElectronicUpdateView : Form
    {

        private readonly int rentableElectronicId;
        private readonly ElectronicController electronicController = new ElectronicController();
        private readonly IElectronicFactory electronicFactory = new ElectronicFactory();

        public ElectronicUpdateView(int rentableId)
        {
            InitializeComponent();
            this.rentableElectronicId = rentableId;
            LoadOldElectronicData(rentableElectronicId);
        }

        private void LoadOldElectronicData(int rentableElectronicId)
        {
            ElectronicEntity electronic = electronicFactory.CreateElectronicEntity();
            electronic = electronicController.GetElectronicById(rentableElectronicId);
            txtOldElectronicType.Text = electronic.NAME;
            txtOldDescription.Text = electronic.DESCRIPTION;
            txtOldCostUsage.Text = electronic.COSTUSAGEPERDAY.ToString();
            txtOldBrand.Text = electronic.BRAND;
            txtOldModel.Text = electronic.MODEL;
            txtOldSerialNumber.Text = electronic.SERIALNUMBER;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string electronicType = txtNewElectronicType.Text;
                string description = txtNewDescription.Text;
                string costUsage = txtNewCostUsage.Text;
                string brand = txtNewBrand.Text;
                string model = txtNewModel.Text;
                string serialNumber = txtNewSerialNumber.Text;
                electronicController.UpdateElectronic(rentableElectronicId, electronicType, description, costUsage, brand, model, serialNumber);
                MessageBox.Show("Dispositivo electronico actualizado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



    }
}
