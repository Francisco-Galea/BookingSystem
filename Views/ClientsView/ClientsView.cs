

using Booking.Controllers;

namespace Booking.Views.ClientsView
{
    public partial class ClientsView : Form
    {

        private readonly ClientController clientController = new ClientController();

        public ClientsView()
        {
            InitializeComponent();
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

        }
    }
}
