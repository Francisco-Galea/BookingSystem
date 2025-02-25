using Boocking.Views.BookingsView;
using Booking.Views.ClientsView;

namespace Boocking.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingView bookingsView = new BookingView();
            this.Hide();
            bookingsView.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsView clientsView = new ClientsView();
            this.Hide();
            clientsView.Show();
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            RentablesView rentableItemsView = new RentablesView();
            this.Hide();
            rentableItemsView.Show();
        }

    }
}
