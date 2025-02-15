using Boocking.Controllers;

namespace Boocking.Views.BookingsView
{
    public partial class ItemsView : Form
    {
        private readonly BookingController bookingController = new BookingController();

        public ItemsView()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedEntity = cbbRentableEntities.SelectedItem as string;
                bookingController.CreateBooking(selectedEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
