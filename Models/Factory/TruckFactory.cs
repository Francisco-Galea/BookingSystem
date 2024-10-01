using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models.Factory
{
    public class TruckFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string Brand, string Model, decimal CostUsagePerHour)
        {
            return new Truck(Brand, Model, CostUsagePerHour);
        }
    }
}
