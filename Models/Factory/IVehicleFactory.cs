using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models.Factory
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string Brand, string Model, decimal CostUsagePerHour);
    }
}
