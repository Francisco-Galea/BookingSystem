using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaReservas.Models;

namespace SistemaReservas.DAOs.VehicleDAO
{
    public interface IVehicleDAO
    {
        void CreateVehicle(Vehicle vehicle);

    }
}
