using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models.Factory
{
    public class MotorbikeFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string Brand, string Model, decimal CostUsagePerHour)
        {
            return new Motorbike(Brand, Model, CostUsagePerHour);   
        }
    }
}
