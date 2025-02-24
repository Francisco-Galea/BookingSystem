using Boocking.Models.Entities;
using Booking.Controllers;

namespace Booking.Views.ClientsView
{
    public partial class ClientsView : Form
    {

        private readonly ClientController clientController = new ClientController();

        public ClientsView()
        {
            InitializeComponent();
            Getclients();
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            try
            {
                string clientName = txtName.Text;
                string lastName = txtLastName.Text;
                string phoneNumber = txtPhoneNumber.Text;
                clientController.CreateClient(clientName, lastName, phoneNumber);
            }
            catch
            {

            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = (int)dgvClients.SelectedRows[0].Cells["Clientid"].Value;
                UpdateClientView updateClientView = new UpdateClientView(clientId);
                updateClientView.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = (int)dgvClients.SelectedRows[0].Cells["Clientid"].Value;
                clientController.DeleteClient(clientId);
            }
            catch
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void Getclients()
        {
            try
            {
                List<ClientEntity> clients = new List<ClientEntity>();
                clients = clientController.GetClients();
                LoadClientsIntoDataGrid(clients);
            }
            catch
            {

            }
        }

        private void LoadClientsIntoDataGrid(List<ClientEntity> clients)
        {
            try
            {
                foreach (ClientEntity client in clients)
                {
                    dgvClients.Rows.Add(client.CLIENTID, client.NAME, client.LASTNAME, client.PHONENUMBER);
                }
            }
            catch
            {

            }
        }

    }
}
