using Boocking.Views.BookingsView;
using Booking.Views.ClientsView;

namespace Boocking.Views
{
    public partial class MainView : Form
    {

        private RentablesView rentablesView;
        private ClientsView clientsView;
        private BookingView bookingView;

        public MainView()
        {
            InitializeComponent();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            if (rentablesView == null || rentablesView.IsDisposed)
            {
                rentablesView = new RentablesView(this);  // Creamos una nueva vista si no existe
            }
            this.Hide();
            rentablesView.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if (clientsView == null || clientsView.IsDisposed)
            {
                clientsView = new ClientsView(this);  // Creamos una nueva vista si no existe
            }
            this.Hide();
            clientsView.Show();
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            if (bookingView == null || bookingView.IsDisposed)
            {
                bookingView = new BookingView(this);  // Creamos una nueva vista si no existe
            }
            this.Hide();
            bookingView.Show();
        }

    }
}
