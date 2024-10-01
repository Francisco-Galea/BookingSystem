using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models.Factory
{
    public class CarFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string Brand, string Model, decimal CostUsagePerHour)
        {
            return new Car(Brand, Model, CostUsagePerHour);
        }
    }
}
