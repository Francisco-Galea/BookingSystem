using Boocking.Models.Entities;
using Booking.Controllers;

namespace Booking.Views.ClientsView
{
    public partial class UpdateClientView : Form
    {

        private readonly int clientSelectedId;
        private readonly ClientController clientController = new ClientController();

        public UpdateClientView(int clientId)
        {
            InitializeComponent();
            this.clientSelectedId = clientId;
            GetOldClientData(clientSelectedId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNewName.Text;
                string lastName = txtNewLastName.Text;
                string phoneNumber = txtNewNumber.Text;
                clientController.UpdateClient(clientSelectedId, name, lastName, phoneNumber);
                MessageBox.Show("Cliente actualizado con exito con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void GetOldClientData(int clientSelectedId)
        {
            try
            {
                ClientEntity oldClient = new ClientEntity();
                oldClient = clientController.GetClient(clientSelectedId);
                LoadOldClientData(oldClient);
            }
            catch 
            { 

            }
        }

        private void LoadOldClientData(ClientEntity oldClient)
        {
            try
            {
                txtOldName.Text = oldClient.NAME;
                txtOldLastName.Text = oldClient.LASTNAME;
                txtOldNumber.Text = oldClient.PHONENUMBER;
            }
            catch
            {

            }
        }


    }
}
