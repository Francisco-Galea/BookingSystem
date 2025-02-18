using Boocking.Controllers;
using Boocking.Controllers.EntitiesController;
using Boocking.Views.ItemsView.RentableObjectsView;
using Boocking.Views.RentableObjectsView;
using Booking.Controllers;
using Booking.Models.Entities;
using Microsoft.VisualBasic;

namespace Boocking.Views.BookingsView
{
    public partial class ItemsView : Form
    {
        private readonly BookingController bookingController = new BookingController();
        private readonly RentableEntityController rentableEntityController = new RentableEntityController();
        private readonly VehicleController vehicleController = new VehicleController(); 

        public ItemsView()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedEntity = cbbRentableEntities.SelectedItem as string;
                rentableEntityController.CreateSelectedEntity(selectedEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string selectedEntity = cbbSearchOptions.SelectedItem as string;
                List <RentableEntity> entities = rentableEntityController.GetEntitiesByType(selectedEntity);

            }
            catch (Exception)
            {

            }
        }

    }
}
