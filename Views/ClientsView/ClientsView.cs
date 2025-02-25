using Boocking.Models.Entities;
using Boocking.Views;
using Booking.Controllers;

namespace Booking.Views.ClientsView
{
    public partial class ClientsView : Form
    {

        private MainView mainView;
        private readonly ClientController clientController = new ClientController();

        public ClientsView(MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;   
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
                Getclients();
                ClearTextBox();
                MessageBox.Show("Cliente agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId = (int)dgvClients.SelectedRows[0].Cells["Clientid"].Value;
                UpdateClientView updateClientView = new UpdateClientView(clientId);
                updateClientView.ShowDialog();
                Getclients();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un valor a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                
                int clientId = (int)dgvClients.SelectedRows[0].Cells["Clientid"].Value;
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este cliente?",
                                              "Confirmar eliminación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                clientController.DeleteClient(clientId, result);
                Getclients();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un valor a eliminar","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainView.Show();
        }

        private void ClearDataGrid()
        {
            dgvClients.Rows.Clear();
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
                ClearDataGrid();
                foreach (ClientEntity client in clients)
                {
                    dgvClients.Rows.Add(client.CLIENTID, client.NAME, client.LASTNAME, client.PHONENUMBER);
                }
            }
            catch
            {

            }
        }

        private void ClearTextBox()
        {
            txtName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
        }

    }
}
