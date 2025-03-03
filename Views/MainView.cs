using Boocking.Views.BookingsView;
using Booking.Views.ClientsView;

namespace Boocking.Views
{
    public partial class MainView : Form
    {

        private RentablesView rentablesView;
        private ClientsView clientsView;
        private BookingView bookingView;

        #pragma warning disable CS8618 
        public MainView()
        #pragma warning restore CS8618 
        {
            InitializeComponent();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            if (bookingView == null || bookingView.IsDisposed)
            {
                bookingView = new BookingView(this); 
            }
            this.Hide();
            bookingView.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if (clientsView == null || clientsView.IsDisposed)
            {
                clientsView = new ClientsView(this); 
            }
            this.Hide();
            clientsView.Show();
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            if (rentablesView == null || rentablesView.IsDisposed)
            {
                rentablesView = new RentablesView(this); 
            }
            this.Hide();
            rentablesView.Show();
        }

    }
}
