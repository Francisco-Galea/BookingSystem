using Boocking.Controllers.EntitiesController;
using Boocking.Views.ItemsView.RentableObjectsView;
using Boocking.Views.RentableObjectsView;
using Booking.Views.ItemsView.RentableObjectsView.ModifyView;

namespace Booking.Controllers
{
    public class RentableEntityController
    {
        private readonly VehicleController vehicleController = new VehicleController();

        public void CreateSelectedEntity(string selectedEntity)
        {
            try
            {

                switch (selectedEntity)
                {
                    case "Vehiculo":
                        VehicleView vehicleView = new VehicleView();
                        vehicleView.ShowDialog();
                        break;

                    case "Propiedad":
                        PropertyView propertyView = new PropertyView();
                        propertyView.ShowDialog();
                        break;

                    case "Dispositivo electronico":
                        ElectronicView electronicView = new ElectronicView();
                        electronicView.ShowDialog();
                        break;

                    case "Indumentaria":
                        IndumentaryView indumentaryView = new IndumentaryView();
                        indumentaryView.ShowDialog();
                        break;

                }

            }
            catch (Exception)
            {
                MessageBox.Show($"Seleccione una opcion valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Invalid option");
            }
        }

        public void DeleteSelectedEntity(int entityId, string selectedEntity)
        {
            try
            {
                switch (selectedEntity)
                {
                    case "Vehicle":
                        vehicleController.DeleteVehicle(entityId);
                        break;

                    case "Propiedad":
                        break;

                    case "Dispositivo electronico":
                        break;

                    case "Indumentaria":
                        break;
                }
            }
            catch
            {

            }
        }

        public void UpdateSelectedEntity(int entityId, string selectedEntity)
        {
            try
            {
                switch (selectedEntity)
                {
                    case "Vehicle":
                        VehicleUpdateView vehicleUpdateView = new VehicleUpdateView(entityId);
                        vehicleUpdateView.ShowDialog();
                        break;

                    case "Propiedad":
                        break;

                    case "Dispositivo electronico":
                        break;

                    case "Indumentaria":
                        break;
                }
            }
            catch
            {

            }
        }

    }
}
