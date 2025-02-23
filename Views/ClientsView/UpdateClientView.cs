using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                this.Close();
            }
            catch 
            { 
            
            }
        } 

    }
}
