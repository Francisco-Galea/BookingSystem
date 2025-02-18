using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boocking.Controllers.EntitiesController;
using Boocking.Models.Entities.RentableEntities;
using Boocking.Views.ItemsView.RentableObjectsView;
using Boocking.Views.RentableObjectsView;
using Booking.Models.Entities;
using Microsoft.VisualBasic;

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

        public List<RentableEntity> GetEntitiesByType(string entityType)
        {
            switch (entityType)
            {
                case "Vehiculo":
                    break;

                case "Propiedad":
                    break;

                case "Dispositivo electronico":
                    break;

                case "Indumentaria":
                    break;
            }



        }

    }
}
